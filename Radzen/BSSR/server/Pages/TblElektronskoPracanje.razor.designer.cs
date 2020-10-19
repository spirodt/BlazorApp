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
    public partial class TblElektronskoPracanjeComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblElektronskoPracanje> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblElektronskoPracanje> _getTblElektronskoPracanjesResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblElektronskoPracanje> getTblElektronskoPracanjesResult
        {
            get
            {
                return _getTblElektronskoPracanjesResult;
            }
            set
            {
                if (!object.Equals(_getTblElektronskoPracanjesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblElektronskoPracanjesResult", NewValue = value, OldValue = _getTblElektronskoPracanjesResult };
                    _getTblElektronskoPracanjesResult = value;
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

            var bssr4GetTblElektronskoPracanjesResult = await Bssr4.GetTblElektronskoPracanjes(new Query() { Filter = "i => i.Naziv.Contains(@0) || i.Zabeleska.Contains(@1) || i.DokumentValue.Contains(@2) || i.PratenOD.Contains(@3) || i.PratenDO.Contains(@4) || i.GeneriranKodNaDokument.Contains(@5)", FilterParameters = new object[] { search, search, search, search, search, search } });
            getTblElektronskoPracanjesResult = bssr4GetTblElektronskoPracanjesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblElektronskoPracanje>("Add Tbl Elektronsko Pracanje", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblElektronskoPracanjesToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Elektronsko Pracanje");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblElektronskoPracanjesToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Elektronsko Pracanje");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblElektronskoPracanje args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblElektronskoPracanje>("Edit Tbl Elektronsko Pracanje", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblElektronskoPracanjeResult = await Bssr4.DeleteTblElektronskoPracanje(data.ID);
                    if (bssr4DeleteTblElektronskoPracanjeResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblElektronskoPracanjeException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblElektronskoPracanje");
            }
        }
    }
}
