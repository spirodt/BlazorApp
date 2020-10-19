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
    public partial class EditTblElektronskoPracanjeComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblElektronskoPracanje _tblelektronskopracanje;
        protected Bssr.Models.Bssr4.TblElektronskoPracanje tblelektronskopracanje
        {
            get
            {
                return _tblelektronskopracanje;
            }
            set
            {
                if (!object.Equals(_tblelektronskopracanje, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblelektronskopracanje", NewValue = value, OldValue = _tblelektronskopracanje };
                    _tblelektronskopracanje = value;
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
            var bssr4GetTblElektronskoPracanjeByIdResult = await Bssr4.GetTblElektronskoPracanjeById(ID);
            tblelektronskopracanje = bssr4GetTblElektronskoPracanjeByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblElektronskoPracanje args)
        {
            try
            {
                var bssr4UpdateTblElektronskoPracanjeResult = await Bssr4.UpdateTblElektronskoPracanje(ID, tblelektronskopracanje);
                DialogService.Close(tblelektronskopracanje);
            }
            catch (System.Exception bssr4UpdateTblElektronskoPracanjeException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblElektronskoPracanje");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
