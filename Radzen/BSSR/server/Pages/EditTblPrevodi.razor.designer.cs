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
    public partial class EditTblPrevodiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblPrevodi _tblprevodi;
        protected Bssr.Models.Bssr4.TblPrevodi tblprevodi
        {
            get
            {
                return _tblprevodi;
            }
            set
            {
                if (!object.Equals(_tblprevodi, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblprevodi", NewValue = value, OldValue = _tblprevodi };
                    _tblprevodi = value;
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
            var bssr4GetTblPrevodiByIdResult = await Bssr4.GetTblPrevodiById(ID);
            tblprevodi = bssr4GetTblPrevodiByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPrevodi args)
        {
            try
            {
                var bssr4UpdateTblPrevodiResult = await Bssr4.UpdateTblPrevodi(ID, tblprevodi);
                DialogService.Close(tblprevodi);
            }
            catch (System.Exception bssr4UpdateTblPrevodiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPrevodi");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
