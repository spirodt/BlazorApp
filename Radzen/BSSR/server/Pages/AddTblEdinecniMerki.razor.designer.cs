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
    public partial class AddTblEdinecniMerkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblEdinecniMerki _tbledinecnimerki;
        protected Bssr.Models.Bssr4.TblEdinecniMerki tbledinecnimerki
        {
            get
            {
                return _tbledinecnimerki;
            }
            set
            {
                if (!object.Equals(_tbledinecnimerki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbledinecnimerki", NewValue = value, OldValue = _tbledinecnimerki };
                    _tbledinecnimerki = value;
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
            tbledinecnimerki = new Bssr.Models.Bssr4.TblEdinecniMerki(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblEdinecniMerki args)
        {
            try
            {
                var bssr4CreateTblEdinecniMerkiResult = await Bssr4.CreateTblEdinecniMerki(tbledinecnimerki);
                DialogService.Close(tbledinecnimerki);
            }
            catch (System.Exception bssr4CreateTblEdinecniMerkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblEdinecniMerki!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
