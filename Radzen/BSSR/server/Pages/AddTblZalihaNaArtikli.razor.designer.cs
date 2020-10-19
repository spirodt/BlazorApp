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
    public partial class AddTblZalihaNaArtikliComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblZalihaNaArtikli _tblzalihanaartikli;
        protected Bssr.Models.Bssr4.TblZalihaNaArtikli tblzalihanaartikli
        {
            get
            {
                return _tblzalihanaartikli;
            }
            set
            {
                if (!object.Equals(_tblzalihanaartikli, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblzalihanaartikli", NewValue = value, OldValue = _tblzalihanaartikli };
                    _tblzalihanaartikli = value;
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
            tblzalihanaartikli = new Bssr.Models.Bssr4.TblZalihaNaArtikli(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblZalihaNaArtikli args)
        {
            try
            {
                var bssr4CreateTblZalihaNaArtikliResult = await Bssr4.CreateTblZalihaNaArtikli(tblzalihanaartikli);
                DialogService.Close(tblzalihanaartikli);
            }
            catch (System.Exception bssr4CreateTblZalihaNaArtikliException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblZalihaNaArtikli!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
