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
    public partial class TblSesijaComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblSesija> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblSesija> _getTblSesijasResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblSesija> getTblSesijasResult
        {
            get
            {
                return _getTblSesijasResult;
            }
            set
            {
                if (!object.Equals(_getTblSesijasResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblSesijasResult", NewValue = value, OldValue = _getTblSesijasResult };
                    _getTblSesijasResult = value;
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

            var bssr4GetTblSesijasResult = await Bssr4.GetTblSesijas(new Query() { Filter = "i => ", FilterParameters = new object[] {  } });
            getTblSesijasResult = bssr4GetTblSesijasResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblSesija>("Add Tbl Sesija", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblSesijasToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Sesija");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblSesijasToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Sesija");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblSesija args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblSesija>("Edit Tbl Sesija", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblSesijaResult = await Bssr4.DeleteTblSesija(data.ID);
                    if (bssr4DeleteTblSesijaResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblSesijaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSesija");
            }
        }
    }
}
