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
    public partial class EditTblPriemStavkiComponent : ComponentBase
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

        [Parameter]
        public dynamic ID { get; set; }

        Bssr.Models.Bssr4.TblPriemStavki _tblpriemstavki;
        protected Bssr.Models.Bssr4.TblPriemStavki tblpriemstavki
        {
            get
            {
                return _tblpriemstavki;
            }
            set
            {
                if (!object.Equals(_tblpriemstavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblpriemstavki", NewValue = value, OldValue = _tblpriemstavki };
                    _tblpriemstavki = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPriem> _getTblPriemsFortblPriemIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPriem> getTblPriemsFortblPriemIDResult
        {
            get
            {
                return _getTblPriemsFortblPriemIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPriemsFortblPriemIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPriemsFortblPriemIDResult", NewValue = value, OldValue = _getTblPriemsFortblPriemIDResult };
                    _getTblPriemsFortblPriemIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblArtikal> _getTblArtikalsFortblArtikalIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblArtikal> getTblArtikalsFortblArtikalIDResult
        {
            get
            {
                return _getTblArtikalsFortblArtikalIDResult;
            }
            set
            {
                if (!object.Equals(_getTblArtikalsFortblArtikalIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblArtikalsFortblArtikalIDResult", NewValue = value, OldValue = _getTblArtikalsFortblArtikalIDResult };
                    _getTblArtikalsFortblArtikalIDResult = value;
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
            var bssr4GetTblPriemStavkiByIdResult = await Bssr4.GetTblPriemStavkiById(ID);
            tblpriemstavki = bssr4GetTblPriemStavkiByIdResult;

            var bssr4GetTblPriemsResult = await Bssr4.GetTblPriems();
            getTblPriemsFortblPriemIDResult = bssr4GetTblPriemsResult;

            var bssr4GetTblArtikalsResult = await Bssr4.GetTblArtikals();
            getTblArtikalsFortblArtikalIDResult = bssr4GetTblArtikalsResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPriemStavki args)
        {
            try
            {
                var bssr4UpdateTblPriemStavkiResult = await Bssr4.UpdateTblPriemStavki(ID, tblpriemstavki);
                DialogService.Close(tblpriemstavki);
            }
            catch (System.Exception bssr4UpdateTblPriemStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPriemStavki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
