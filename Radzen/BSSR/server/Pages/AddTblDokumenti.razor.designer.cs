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
    public partial class AddTblDokumentiComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblTipNaDokument> _getTblTipNaDokumentsForTipNaDokumentResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblTipNaDokument> getTblTipNaDokumentsForTipNaDokumentResult
        {
            get
            {
                return _getTblTipNaDokumentsForTipNaDokumentResult;
            }
            set
            {
                if (!object.Equals(_getTblTipNaDokumentsForTipNaDokumentResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblTipNaDokumentsForTipNaDokumentResult", NewValue = value, OldValue = _getTblTipNaDokumentsForTipNaDokumentResult };
                    _getTblTipNaDokumentsForTipNaDokumentResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPartneri> _getTblPartnerisFortblPartnerIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPartneri> getTblPartnerisFortblPartnerIDResult
        {
            get
            {
                return _getTblPartnerisFortblPartnerIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPartnerisFortblPartnerIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPartnerisFortblPartnerIDResult", NewValue = value, OldValue = _getTblPartnerisFortblPartnerIDResult };
                    _getTblPartnerisFortblPartnerIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblDokumenti _tbldokumenti;
        protected Bssr.Models.Bssr4.TblDokumenti tbldokumenti
        {
            get
            {
                return _tbldokumenti;
            }
            set
            {
                if (!object.Equals(_tbldokumenti, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbldokumenti", NewValue = value, OldValue = _tbldokumenti };
                    _tbldokumenti = value;
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
            var bssr4GetTblTipNaDokumentsResult = await Bssr4.GetTblTipNaDokuments();
            getTblTipNaDokumentsForTipNaDokumentResult = bssr4GetTblTipNaDokumentsResult;

            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris();
            getTblPartnerisFortblPartnerIDResult = bssr4GetTblPartnerisResult;

            tbldokumenti = new Bssr.Models.Bssr4.TblDokumenti(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblDokumenti args)
        {
            try
            {
                var bssr4CreateTblDokumentiResult = await Bssr4.CreateTblDokumenti(tbldokumenti);
                DialogService.Close(tbldokumenti);
            }
            catch (System.Exception bssr4CreateTblDokumentiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblDokumenti!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
