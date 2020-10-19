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
    public partial class EditTblNormativStavkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNormativStavki _tblnormativstavki;
        protected Bssr.Models.Bssr4.TblNormativStavki tblnormativstavki
        {
            get
            {
                return _tblnormativstavki;
            }
            set
            {
                if (!object.Equals(_tblnormativstavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnormativstavki", NewValue = value, OldValue = _tblnormativstavki };
                    _tblnormativstavki = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblNormativ> _getTblNormativsFortblNormativIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNormativ> getTblNormativsFortblNormativIDResult
        {
            get
            {
                return _getTblNormativsFortblNormativIDResult;
            }
            set
            {
                if (!object.Equals(_getTblNormativsFortblNormativIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNormativsFortblNormativIDResult", NewValue = value, OldValue = _getTblNormativsFortblNormativIDResult };
                    _getTblNormativsFortblNormativIDResult = value;
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
            var bssr4GetTblNormativStavkiByIdResult = await Bssr4.GetTblNormativStavkiById(ID);
            tblnormativstavki = bssr4GetTblNormativStavkiByIdResult;

            var bssr4GetTblNormativsResult = await Bssr4.GetTblNormativs();
            getTblNormativsFortblNormativIDResult = bssr4GetTblNormativsResult;

            var bssr4GetTblArtikalsResult = await Bssr4.GetTblArtikals();
            getTblArtikalsFortblArtikalIDResult = bssr4GetTblArtikalsResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNormativStavki args)
        {
            try
            {
                var bssr4UpdateTblNormativStavkiResult = await Bssr4.UpdateTblNormativStavki(ID, tblnormativstavki);
                DialogService.Close(tblnormativstavki);
            }
            catch (System.Exception bssr4UpdateTblNormativStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblNormativStavki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
