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
    public partial class TblPartneriComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblPartneri> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblPartneri> _getTblPartnerisResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPartneri> getTblPartnerisResult
        {
            get
            {
                return _getTblPartnerisResult;
            }
            set
            {
                if (!object.Equals(_getTblPartnerisResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPartnerisResult", NewValue = value, OldValue = _getTblPartnerisResult };
                    _getTblPartnerisResult = value;
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

            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris(new Query() { Filter = "i => i.Sifra.Contains(@0) || i.Naziv.Contains(@1) || i.Adresa.Contains(@2) || i.Telefoni.Contains(@3) || i.Email.Contains(@4) || i.EDB.Contains(@5) || i.Mesto.Contains(@6)", FilterParameters = new object[] { search, search, search, search, search, search, search } });
            getTblPartnerisResult = bssr4GetTblPartnerisResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblPartneri>("Add Tbl Partneri", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblPartnerisToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Partneri");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblPartnerisToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Partneri");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblPartneri args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblPartneri>("Edit Tbl Partneri", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblPartneriResult = await Bssr4.DeleteTblPartneri(data.ID);
                    if (bssr4DeleteTblPartneriResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblPartneriException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPartneri");
            }
        }
    }
}
