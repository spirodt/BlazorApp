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
    public partial class TblArtikalComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblArtikal> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblArtikal> _getTblArtikalsResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblArtikal> getTblArtikalsResult
        {
            get
            {
                return _getTblArtikalsResult;
            }
            set
            {
                if (!object.Equals(_getTblArtikalsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblArtikalsResult", NewValue = value, OldValue = _getTblArtikalsResult };
                    _getTblArtikalsResult = value;
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

            var bssr4GetTblArtikalsResult = await Bssr4.GetTblArtikals(new Query() { Filter = "i => i.Sifra.Contains(@0) || i.Naziv.Contains(@1) || i.AltNaziv.Contains(@2) || i.AltSifra.Contains(@3) || i.KlucniZborovi.Contains(@4) || i.Barkod1.Contains(@5) || i.Barkod2.Contains(@6) || i.AltNaziv2.Contains(@7) || i.Image.Contains(@8)", FilterParameters = new object[] { search, search, search, search, search, search, search, search, search } });
            getTblArtikalsResult = bssr4GetTblArtikalsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblArtikal>("Add Tbl Artikal", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblArtikalsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Artikal");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblArtikalsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Artikal");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblArtikal args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblArtikal>("Edit Tbl Artikal", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblArtikalResult = await Bssr4.DeleteTblArtikal(data.ID);
                    if (bssr4DeleteTblArtikalResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblArtikalException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblArtikal");
            }
        }
    }
}
