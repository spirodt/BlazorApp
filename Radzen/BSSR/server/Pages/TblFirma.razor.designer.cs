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
    public partial class TblFirmaComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblFirma> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblFirma> _getTblFirmasResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblFirma> getTblFirmasResult
        {
            get
            {
                return _getTblFirmasResult;
            }
            set
            {
                if (!object.Equals(_getTblFirmasResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblFirmasResult", NewValue = value, OldValue = _getTblFirmasResult };
                    _getTblFirmasResult = value;
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

            var bssr4GetTblFirmasResult = await Bssr4.GetTblFirmas(new Query() { Filter = "i => i.ImeNaFirma.Contains(@0) || i.DanocenBroj.Contains(@1) || i.BankaDeponent.Contains(@2) || i.Grad.Contains(@3) || i.Adresa.Contains(@4) || i.PostenskiBroj.Contains(@5) || i.Telefon.Contains(@6) || i.Faks.Contains(@7) || i.EMail.Contains(@8) || i.MaticenBroj.Contains(@9) || i.ZiroSmetka.Contains(@10) || i.txIDFirma.Contains(@11)", FilterParameters = new object[] { search, search, search, search, search, search, search, search, search, search, search, search } });
            getTblFirmasResult = bssr4GetTblFirmasResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblFirma>("Add Tbl Firma", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblFirmasToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Firma");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblFirmasToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Firma");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblFirma args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblFirma>("Edit Tbl Firma", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblFirmaResult = await Bssr4.DeleteTblFirma(data.ID);
                    if (bssr4DeleteTblFirmaResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblFirmaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblFirma");
            }
        }
    }
}
