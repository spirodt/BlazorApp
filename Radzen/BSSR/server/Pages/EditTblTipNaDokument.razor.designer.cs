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
    public partial class EditTblTipNaDokumentComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblTipNaDokument _tbltipnadokument;
        protected Bssr.Models.Bssr4.TblTipNaDokument tbltipnadokument
        {
            get
            {
                return _tbltipnadokument;
            }
            set
            {
                if (!object.Equals(_tbltipnadokument, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbltipnadokument", NewValue = value, OldValue = _tbltipnadokument };
                    _tbltipnadokument = value;
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
            var bssr4GetTblTipNaDokumentByIdResult = await Bssr4.GetTblTipNaDokumentById(ID);
            tbltipnadokument = bssr4GetTblTipNaDokumentByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblTipNaDokument args)
        {
            try
            {
                var bssr4UpdateTblTipNaDokumentResult = await Bssr4.UpdateTblTipNaDokument(ID, tbltipnadokument);
                DialogService.Close(tbltipnadokument);
            }
            catch (System.Exception bssr4UpdateTblTipNaDokumentException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblTipNaDokument");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
