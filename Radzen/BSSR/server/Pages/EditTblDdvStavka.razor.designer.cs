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
    public partial class EditTblDdvStavkaComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblDdvStavka _tblddvstavka;
        protected Bssr.Models.Bssr4.TblDdvStavka tblddvstavka
        {
            get
            {
                return _tblddvstavka;
            }
            set
            {
                if (!object.Equals(_tblddvstavka, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblddvstavka", NewValue = value, OldValue = _tblddvstavka };
                    _tblddvstavka = value;
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
            var bssr4GetTblDdvStavkaByIdResult = await Bssr4.GetTblDdvStavkaById(ID);
            tblddvstavka = bssr4GetTblDdvStavkaByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblDdvStavka args)
        {
            try
            {
                var bssr4UpdateTblDdvStavkaResult = await Bssr4.UpdateTblDdvStavka(ID, tblddvstavka);
                DialogService.Close(tblddvstavka);
            }
            catch (System.Exception bssr4UpdateTblDdvStavkaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblDdvStavka");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
