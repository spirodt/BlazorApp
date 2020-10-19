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
    public partial class TblTipNaDokumentComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblTipNaDokument> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblTipNaDokument> _getTblTipNaDokumentsResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblTipNaDokument> getTblTipNaDokumentsResult
        {
            get
            {
                return _getTblTipNaDokumentsResult;
            }
            set
            {
                if (!object.Equals(_getTblTipNaDokumentsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblTipNaDokumentsResult", NewValue = value, OldValue = _getTblTipNaDokumentsResult };
                    _getTblTipNaDokumentsResult = value;
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

            var bssr4GetTblTipNaDokumentsResult = await Bssr4.GetTblTipNaDokuments(new Query() { Filter = "i => i.Naziv.Contains(@0) || i.ReportFileName.Contains(@1) || i.Naslov.Contains(@2)", FilterParameters = new object[] { search, search, search } });
            getTblTipNaDokumentsResult = bssr4GetTblTipNaDokumentsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblTipNaDokument>("Add Tbl Tip Na Dokument", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblTipNaDokumentsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Tip Na Dokument");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblTipNaDokumentsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Tip Na Dokument");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblTipNaDokument args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblTipNaDokument>("Edit Tbl Tip Na Dokument", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblTipNaDokumentResult = await Bssr4.DeleteTblTipNaDokument(data.ID);
                    if (bssr4DeleteTblTipNaDokumentResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblTipNaDokumentException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblTipNaDokument");
            }
        }
    }
}
