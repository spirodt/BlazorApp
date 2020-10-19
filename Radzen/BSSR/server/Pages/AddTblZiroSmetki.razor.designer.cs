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
    public partial class AddTblZiroSmetkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblZiroSmetki _tblzirosmetki;
        protected Bssr.Models.Bssr4.TblZiroSmetki tblzirosmetki
        {
            get
            {
                return _tblzirosmetki;
            }
            set
            {
                if (!object.Equals(_tblzirosmetki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblzirosmetki", NewValue = value, OldValue = _tblzirosmetki };
                    _tblzirosmetki = value;
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
            tblzirosmetki = new Bssr.Models.Bssr4.TblZiroSmetki(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblZiroSmetki args)
        {
            try
            {
                var bssr4CreateTblZiroSmetkiResult = await Bssr4.CreateTblZiroSmetki(tblzirosmetki);
                DialogService.Close(tblzirosmetki);
            }
            catch (System.Exception bssr4CreateTblZiroSmetkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblZiroSmetki!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
