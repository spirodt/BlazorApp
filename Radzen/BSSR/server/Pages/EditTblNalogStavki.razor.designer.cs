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
    public partial class EditTblNalogStavkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNalogStavki _tblnalogstavki;
        protected Bssr.Models.Bssr4.TblNalogStavki tblnalogstavki
        {
            get
            {
                return _tblnalogstavki;
            }
            set
            {
                if (!object.Equals(_tblnalogstavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnalogstavki", NewValue = value, OldValue = _tblnalogstavki };
                    _tblnalogstavki = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblNalog> _getTblNalogsFortblNalogIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNalog> getTblNalogsFortblNalogIDResult
        {
            get
            {
                return _getTblNalogsFortblNalogIDResult;
            }
            set
            {
                if (!object.Equals(_getTblNalogsFortblNalogIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNalogsFortblNalogIDResult", NewValue = value, OldValue = _getTblNalogsFortblNalogIDResult };
                    _getTblNalogsFortblNalogIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblNormativ> _getTblNormativsFortblNomativIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNormativ> getTblNormativsFortblNomativIDResult
        {
            get
            {
                return _getTblNormativsFortblNomativIDResult;
            }
            set
            {
                if (!object.Equals(_getTblNormativsFortblNomativIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNormativsFortblNomativIDResult", NewValue = value, OldValue = _getTblNormativsFortblNomativIDResult };
                    _getTblNormativsFortblNomativIDResult = value;
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
            var bssr4GetTblNalogStavkiByIdResult = await Bssr4.GetTblNalogStavkiById(ID);
            tblnalogstavki = bssr4GetTblNalogStavkiByIdResult;

            var bssr4GetTblNalogsResult = await Bssr4.GetTblNalogs();
            getTblNalogsFortblNalogIDResult = bssr4GetTblNalogsResult;

            var bssr4GetTblNormativsResult = await Bssr4.GetTblNormativs();
            getTblNormativsFortblNomativIDResult = bssr4GetTblNormativsResult;

            var bssr4GetTblArtikalsResult = await Bssr4.GetTblArtikals();
            getTblArtikalsFortblArtikalIDResult = bssr4GetTblArtikalsResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNalogStavki args)
        {
            try
            {
                var bssr4UpdateTblNalogStavkiResult = await Bssr4.UpdateTblNalogStavki(ID, tblnalogstavki);
                DialogService.Close(tblnalogstavki);
            }
            catch (System.Exception bssr4UpdateTblNalogStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblNalogStavki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
