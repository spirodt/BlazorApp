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
    public partial class AddTblSmetkaStavkiIzmenetaComponent : ComponentBase
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
            tblsmetkastavkiizmenetum = new Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum args)
        {
            try
            {
                var bssr4CreateTblSmetkaStavkiIzmenetumResult = await Bssr4.CreateTblSmetkaStavkiIzmenetum(tblsmetkastavkiizmenetum);
                DialogService.Close(tblsmetkastavkiizmenetum);
            }
            catch (System.Exception bssr4CreateTblSmetkaStavkiIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSmetkaStavkiIzmenetum!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
