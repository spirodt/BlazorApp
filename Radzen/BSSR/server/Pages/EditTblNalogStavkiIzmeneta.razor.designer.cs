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
    public partial class EditTblNalogStavkiIzmenetaComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNalogStavkiIzmenetum _tblnalogstavkiizmenetum;
        protected Bssr.Models.Bssr4.TblNalogStavkiIzmenetum tblnalogstavkiizmenetum
        {
            get
            {
                return _tblnalogstavkiizmenetum;
            }
            set
            {
                if (!object.Equals(_tblnalogstavkiizmenetum, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnalogstavkiizmenetum", NewValue = value, OldValue = _tblnalogstavkiizmenetum };
                    _tblnalogstavkiizmenetum = value;
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
            var bssr4GetTblNalogStavkiIzmenetumByIdResult = await Bssr4.GetTblNalogStavkiIzmenetumById(ID);
            tblnalogstavkiizmenetum = bssr4GetTblNalogStavkiIzmenetumByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNalogStavkiIzmenetum args)
        {
            try
            {
                var bssr4UpdateTblNalogStavkiIzmenetumResult = await Bssr4.UpdateTblNalogStavkiIzmenetum(ID, tblnalogstavkiizmenetum);
                DialogService.Close(tblnalogstavkiizmenetum);
            }
            catch (System.Exception bssr4UpdateTblNalogStavkiIzmenetumException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblNalogStavkiIzmenetum");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
