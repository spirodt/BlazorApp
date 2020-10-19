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
    public partial class TblIzvodiStavkiComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblIzvodiStavki> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblIzvodiStavki> _getTblIzvodiStavkisResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblIzvodiStavki> getTblIzvodiStavkisResult
        {
            get
            {
                return _getTblIzvodiStavkisResult;
            }
            set
            {
                if (!object.Equals(_getTblIzvodiStavkisResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblIzvodiStavkisResult", NewValue = value, OldValue = _getTblIzvodiStavkisResult };
                    _getTblIzvodiStavkisResult = value;
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

            var bssr4GetTblIzvodiStavkisResult = await Bssr4.GetTblIzvodiStavkis(new Query() { Filter = "i => i.BrojNaDokument.Contains(@0)", FilterParameters = new object[] { search } });
            getTblIzvodiStavkisResult = bssr4GetTblIzvodiStavkisResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblIzvodiStavki>("Add Tbl Izvodi Stavki", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblIzvodiStavkisToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Izvodi Stavki");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblIzvodiStavkisToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Izvodi Stavki");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblIzvodiStavki args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblIzvodiStavki>("Edit Tbl Izvodi Stavki", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblIzvodiStavkiResult = await Bssr4.DeleteTblIzvodiStavki(data.ID);
                    if (bssr4DeleteTblIzvodiStavkiResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblIzvodiStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblIzvodiStavki");
            }
        }
    }
}
