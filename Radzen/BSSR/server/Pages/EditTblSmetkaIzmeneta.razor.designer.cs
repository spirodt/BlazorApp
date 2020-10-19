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
    public partial class EditTblSmetkaIzmenetaComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblSmetkaIzmenetum _tblsmetkaizmenetum;
        protected Bssr.Models.Bssr4.TblSmetkaIzmenetum tblsmetkaizmenetum
        {
            get
            {
                return _tblsmetkaizmenetum;
            }
            set
            {
                if (!object.Equals(_tblsmetkaizmenetum, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblsmetkaizmenetum", NewValue = value, OldValue = _tblsmetkaizmenetum };
                    _tblsmetkaizmenetum = value;
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
            var bssr4GetTblSmetkaIzmenetumByIdResult = await Bssr4.GetTblSmetkaIzmenetumById(ID);
            tblsmetkaizmenetum = bssr4GetTblSmetkaIzmenetumByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblSmetkaIzmenetum args)
        {
            try
            {
                var bssr4UpdateTblSmetkaIzmenetumResult = await Bssr4.UpdateTblSmetkaIzmenetum(ID, tblsmetkaizmenetum);
                DialogService.Close(tblsmetkaizmenetum);
            }
            catch (System.Exception bssr4UpdateTblSmetkaIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSmetkaIzmenetum");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
