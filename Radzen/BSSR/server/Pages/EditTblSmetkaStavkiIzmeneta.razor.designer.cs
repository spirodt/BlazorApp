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
    public partial class EditTblSmetkaStavkiIzmenetaComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum _tblsmetkastavkiizmenetum;
        protected Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum tblsmetkastavkiizmenetum
        {
            get
            {
                return _tblsmetkastavkiizmenetum;
            }
            set
            {
                if (!object.Equals(_tblsmetkastavkiizmenetum, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblsmetkastavkiizmenetum", NewValue = value, OldValue = _tblsmetkastavkiizmenetum };
                    _tblsmetkastavkiizmenetum = value;
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
            var bssr4GetTblSmetkaStavkiIzmenetumByIdResult = await Bssr4.GetTblSmetkaStavkiIzmenetumById(ID);
            tblsmetkastavkiizmenetum = bssr4GetTblSmetkaStavkiIzmenetumByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum args)
        {
            try
            {
                var bssr4UpdateTblSmetkaStavkiIzmenetumResult = await Bssr4.UpdateTblSmetkaStavkiIzmenetum(ID, tblsmetkastavkiizmenetum);
                DialogService.Close(tblsmetkastavkiizmenetum);
            }
            catch (System.Exception bssr4UpdateTblSmetkaStavkiIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSmetkaStavkiIzmenetum");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
