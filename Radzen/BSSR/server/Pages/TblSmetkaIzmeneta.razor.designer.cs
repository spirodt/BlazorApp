using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Bssr.Models.Bssr4;
using Microsoft.EntityFrameworkCore;

namespace Bssr.Pages
{
    public partial class TblSmetkaIzmenetaComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected Bssr4Service Bssr4 { get; set; }
        protected RadzenGrid<Bssr.Models.Bssr4.TblSmetkaIzmenetum> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblSmetkaIzmenetum> _getTblSmetkaIzmenetaResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblSmetkaIzmenetum> getTblSmetkaIzmenetaResult
        {
            get
            {
                return _getTblSmetkaIzmenetaResult;
            }
            set
            {
                if (!object.Equals(_getTblSmetkaIzmenetaResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblSmetkaIzmenetaResult", NewValue = value, OldValue = _getTblSmetkaIzmenetaResult };
                    _getTblSmetkaIzmenetaResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var bssr4GetTblSmetkaIzmenetaResult = await Bssr4.GetTblSmetkaIzmeneta(new Query() { Filter = "i => i.Zabeleska.Contains(@0)", FilterParameters = new object[] { search } });
            getTblSmetkaIzmenetaResult = bssr4GetTblSmetkaIzmenetaResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblSmetkaIzmeneta>("Add Tbl Smetka Izmeneta", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblSmetkaIzmenetaToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Smetka Izmeneta");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblSmetkaIzmenetaToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Smetka Izmeneta");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblSmetkaIzmenetum args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblSmetkaIzmeneta>("Edit Tbl Smetka Izmeneta", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblSmetkaIzmenetumResult = await Bssr4.DeleteTblSmetkaIzmenetum(data.ID);
                    if (bssr4DeleteTblSmetkaIzmenetumResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblSmetkaIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSmetkaIzmenetum");
            }
        }
    }
}
