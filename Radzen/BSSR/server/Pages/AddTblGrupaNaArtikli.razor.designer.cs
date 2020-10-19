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
    public partial class AddTblGrupaNaArtikliComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblFirma> _getTblFirmasForFirmaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblFirma> getTblFirmasForFirmaIDResult
        {
            get
            {
                return _getTblFirmasForFirmaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblFirmasForFirmaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblFirmasForFirmaIDResult", NewValue = value, OldValue = _getTblFirmasForFirmaIDResult };
                    _getTblFirmasForFirmaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblGrupaNaArtikli _tblgrupanaartikli;
        protected Bssr.Models.Bssr4.TblGrupaNaArtikli tblgrupanaartikli
        {
            get
            {
                return _tblgrupanaartikli;
            }
            set
            {
                if (!object.Equals(_tblgrupanaartikli, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblgrupanaartikli", NewValue = value, OldValue = _tblgrupanaartikli };
                    _tblgrupanaartikli = value;
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
            var bssr4GetTblFirmasResult = await Bssr4.GetTblFirmas();
            getTblFirmasForFirmaIDResult = bssr4GetTblFirmasResult;

            tblgrupanaartikli = new Bssr.Models.Bssr4.TblGrupaNaArtikli(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblGrupaNaArtikli args)
        {
            try
            {
                var bssr4CreateTblGrupaNaArtikliResult = await Bssr4.CreateTblGrupaNaArtikli(tblgrupanaartikli);
                DialogService.Close(tblgrupanaartikli);
            }
            catch (System.Exception bssr4CreateTblGrupaNaArtikliException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGrupaNaArtikli!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
