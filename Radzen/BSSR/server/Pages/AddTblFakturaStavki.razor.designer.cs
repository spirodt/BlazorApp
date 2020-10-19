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
    public partial class AddTblFakturaStavkiComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblFaktura> _getTblFakturasFortblFakturaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblFaktura> getTblFakturasFortblFakturaIDResult
        {
            get
            {
                return _getTblFakturasFortblFakturaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblFakturasFortblFakturaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblFakturasFortblFakturaIDResult", NewValue = value, OldValue = _getTblFakturasFortblFakturaIDResult };
                    _getTblFakturasFortblFakturaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblFakturaStavki _tblfakturastavki;
        protected Bssr.Models.Bssr4.TblFakturaStavki tblfakturastavki
        {
            get
            {
                return _tblfakturastavki;
            }
            set
            {
                if (!object.Equals(_tblfakturastavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblfakturastavki", NewValue = value, OldValue = _tblfakturastavki };
                    _tblfakturastavki = value;
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
            var bssr4GetTblFakturasResult = await Bssr4.GetTblFakturas();
            getTblFakturasFortblFakturaIDResult = bssr4GetTblFakturasResult;

            tblfakturastavki = new Bssr.Models.Bssr4.TblFakturaStavki(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblFakturaStavki args)
        {
            try
            {
                var bssr4CreateTblFakturaStavkiResult = await Bssr4.CreateTblFakturaStavki(tblfakturastavki);
                DialogService.Close(tblfakturastavki);
            }
            catch (System.Exception bssr4CreateTblFakturaStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblFakturaStavki!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
