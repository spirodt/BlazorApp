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
    public partial class EditTblPodgrupaIdComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblPodgrupaId _tblpodgrupaid;
        protected Bssr.Models.Bssr4.TblPodgrupaId tblpodgrupaid
        {
            get
            {
                return _tblpodgrupaid;
            }
            set
            {
                if (!object.Equals(_tblpodgrupaid, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblpodgrupaid", NewValue = value, OldValue = _tblpodgrupaid };
                    _tblpodgrupaid = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblGrupaNaArtikli> _getTblGrupaNaArtiklisForGrupaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblGrupaNaArtikli> getTblGrupaNaArtiklisForGrupaIDResult
        {
            get
            {
                return _getTblGrupaNaArtiklisForGrupaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblGrupaNaArtiklisForGrupaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblGrupaNaArtiklisForGrupaIDResult", NewValue = value, OldValue = _getTblGrupaNaArtiklisForGrupaIDResult };
                    _getTblGrupaNaArtiklisForGrupaIDResult = value;
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
            var bssr4GetTblPodgrupaIdByIdResult = await Bssr4.GetTblPodgrupaIdById(ID);
            tblpodgrupaid = bssr4GetTblPodgrupaIdByIdResult;

            var bssr4GetTblGrupaNaArtiklisResult = await Bssr4.GetTblGrupaNaArtiklis();
            getTblGrupaNaArtiklisForGrupaIDResult = bssr4GetTblGrupaNaArtiklisResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPodgrupaId args)
        {
            try
            {
                var bssr4UpdateTblPodgrupaIdResult = await Bssr4.UpdateTblPodgrupaId(ID, tblpodgrupaid);
                DialogService.Close(tblpodgrupaid);
            }
            catch (System.Exception bssr4UpdateTblPodgrupaIdException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPodgrupaId");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
