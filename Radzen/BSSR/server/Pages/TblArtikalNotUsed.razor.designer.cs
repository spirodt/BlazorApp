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
    public partial class TblArtikalNotUsedComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblArtikalNotUsed> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblArtikalNotUsed> _getTblArtikalNotUsedsResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblArtikalNotUsed> getTblArtikalNotUsedsResult
        {
            get
            {
                return _getTblArtikalNotUsedsResult;
            }
            set
            {
                if (!object.Equals(_getTblArtikalNotUsedsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblArtikalNotUsedsResult", NewValue = value, OldValue = _getTblArtikalNotUsedsResult };
                    _getTblArtikalNotUsedsResult = value;
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

            var bssr4GetTblArtikalNotUsedsResult = await Bssr4.GetTblArtikalNotUseds(new Query() { Filter = "i => i.Sifra.Contains(@0) || i.Naziv.Contains(@1) || i.AltNaziv.Contains(@2) || i.AltSifra.Contains(@3) || i.KlucniZborovi.Contains(@4) || i.Barkod1.Contains(@5) || i.Barkod2.Contains(@6) || i.AltNaziv2.Contains(@7) || i.Image.Contains(@8)", FilterParameters = new object[] { search, search, search, search, search, search, search, search, search } });
            getTblArtikalNotUsedsResult = bssr4GetTblArtikalNotUsedsResult;
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblArtikalNotUsedsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Artikal Not Used");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblArtikalNotUsedsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Artikal Not Used");

            }
        }
    }
}
