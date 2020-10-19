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
    public partial class TblNalogStavkiIzmenetaComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum> _getTblNalogStavkiIzmenetaResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum> getTblNalogStavkiIzmenetaResult
        {
            get
            {
                return _getTblNalogStavkiIzmenetaResult;
            }
            set
            {
                if (!object.Equals(_getTblNalogStavkiIzmenetaResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNalogStavkiIzmenetaResult", NewValue = value, OldValue = _getTblNalogStavkiIzmenetaResult };
                    _getTblNalogStavkiIzmenetaResult = value;
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

            var bssr4GetTblNalogStavkiIzmenetaResult = await Bssr4.GetTblNalogStavkiIzmeneta(new Query() { Filter = "i => ", FilterParameters = new object[] {  } });
            getTblNalogStavkiIzmenetaResult = bssr4GetTblNalogStavkiIzmenetaResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblNalogStavkiIzmeneta>("Add Tbl Nalog Stavki Izmeneta", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblNalogStavkiIzmenetaToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Nalog Stavki Izmeneta");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblNalogStavkiIzmenetaToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Nalog Stavki Izmeneta");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblNalogStavkiIzmenetum args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblNalogStavkiIzmeneta>("Edit Tbl Nalog Stavki Izmeneta", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblNalogStavkiIzmenetumResult = await Bssr4.DeleteTblNalogStavkiIzmenetum(data.ID);
                    if (bssr4DeleteTblNalogStavkiIzmenetumResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblNalogStavkiIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblNalogStavkiIzmenetum");
            }
        }
    }
}
