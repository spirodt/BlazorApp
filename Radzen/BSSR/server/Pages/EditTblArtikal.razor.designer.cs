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
    public partial class EditTblArtikalComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblArtikal _tblartikal;
        protected Bssr.Models.Bssr4.TblArtikal tblartikal
        {
            get
            {
                return _tblartikal;
            }
            set
            {
                if (!object.Equals(_tblartikal, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblartikal", NewValue = value, OldValue = _tblartikal };
                    _tblartikal = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblDdvStavka> _getTblDdvStavkasFortblDDVStavkaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblDdvStavka> getTblDdvStavkasFortblDDVStavkaIDResult
        {
            get
            {
                return _getTblDdvStavkasFortblDDVStavkaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblDdvStavkasFortblDDVStavkaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblDdvStavkasFortblDDVStavkaIDResult", NewValue = value, OldValue = _getTblDdvStavkasFortblDDVStavkaIDResult };
                    _getTblDdvStavkasFortblDDVStavkaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPodgrupaId> _getTblPodgrupaIdsForPodgrupaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPodgrupaId> getTblPodgrupaIdsForPodgrupaIDResult
        {
            get
            {
                return _getTblPodgrupaIdsForPodgrupaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPodgrupaIdsForPodgrupaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPodgrupaIdsForPodgrupaIDResult", NewValue = value, OldValue = _getTblPodgrupaIdsForPodgrupaIDResult };
                    _getTblPodgrupaIdsForPodgrupaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblEdinecniMerki> _getTblEdinecniMerkisFortblEdinecniMerkiIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblEdinecniMerki> getTblEdinecniMerkisFortblEdinecniMerkiIDResult
        {
            get
            {
                return _getTblEdinecniMerkisFortblEdinecniMerkiIDResult;
            }
            set
            {
                if (!object.Equals(_getTblEdinecniMerkisFortblEdinecniMerkiIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblEdinecniMerkisFortblEdinecniMerkiIDResult", NewValue = value, OldValue = _getTblEdinecniMerkisFortblEdinecniMerkiIDResult };
                    _getTblEdinecniMerkisFortblEdinecniMerkiIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var bssr4GetTblArtikalByIdResult = await Bssr4.GetTblArtikalById(ID);
            tblartikal = bssr4GetTblArtikalByIdResult;

            var bssr4GetTblDdvStavkasResult = await Bssr4.GetTblDdvStavkas();
            getTblDdvStavkasFortblDDVStavkaIDResult = bssr4GetTblDdvStavkasResult;

            var bssr4GetTblPodgrupaIdsResult = await Bssr4.GetTblPodgrupaIds();
            getTblPodgrupaIdsForPodgrupaIDResult = bssr4GetTblPodgrupaIdsResult;

            var bssr4GetTblEdinecniMerkisResult = await Bssr4.GetTblEdinecniMerkis();
            getTblEdinecniMerkisFortblEdinecniMerkiIDResult = bssr4GetTblEdinecniMerkisResult;

            var bssr4GetTblFirmasResult = await Bssr4.GetTblFirmas();
            getTblFirmasForFirmaIDResult = bssr4GetTblFirmasResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblArtikal args)
        {
            try
            {
                var bssr4UpdateTblArtikalResult = await Bssr4.UpdateTblArtikal(ID, tblartikal);
                DialogService.Close(tblartikal);
            }
            catch (System.Exception bssr4UpdateTblArtikalException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblArtikal");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
