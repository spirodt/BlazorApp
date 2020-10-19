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
    public partial class EditTblIzvodiStavkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblIzvodiStavki _tblizvodistavki;
        protected Bssr.Models.Bssr4.TblIzvodiStavki tblizvodistavki
        {
            get
            {
                return _tblizvodistavki;
            }
            set
            {
                if (!object.Equals(_tblizvodistavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblizvodistavki", NewValue = value, OldValue = _tblizvodistavki };
                    _tblizvodistavki = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblIzvodi> _getTblIzvodisFortblIzvodiIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblIzvodi> getTblIzvodisFortblIzvodiIDResult
        {
            get
            {
                return _getTblIzvodisFortblIzvodiIDResult;
            }
            set
            {
                if (!object.Equals(_getTblIzvodisFortblIzvodiIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblIzvodisFortblIzvodiIDResult", NewValue = value, OldValue = _getTblIzvodisFortblIzvodiIDResult };
                    _getTblIzvodisFortblIzvodiIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPartneri> _getTblPartnerisForPartnerIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPartneri> getTblPartnerisForPartnerIDResult
        {
            get
            {
                return _getTblPartnerisForPartnerIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPartnerisForPartnerIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPartnerisForPartnerIDResult", NewValue = value, OldValue = _getTblPartnerisForPartnerIDResult };
                    _getTblPartnerisForPartnerIDResult = value;
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
            var bssr4GetTblIzvodiStavkiByIdResult = await Bssr4.GetTblIzvodiStavkiById(ID);
            tblizvodistavki = bssr4GetTblIzvodiStavkiByIdResult;

            var bssr4GetTblIzvodisResult = await Bssr4.GetTblIzvodis();
            getTblIzvodisFortblIzvodiIDResult = bssr4GetTblIzvodisResult;

            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris();
            getTblPartnerisForPartnerIDResult = bssr4GetTblPartnerisResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblIzvodiStavki args)
        {
            try
            {
                var bssr4UpdateTblIzvodiStavkiResult = await Bssr4.UpdateTblIzvodiStavki(ID, tblizvodistavki);
                DialogService.Close(tblizvodistavki);
            }
            catch (System.Exception bssr4UpdateTblIzvodiStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIzvodiStavki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
