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
    public partial class EditTblNarackiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNaracki _tblnaracki;
        protected Bssr.Models.Bssr4.TblNaracki tblnaracki
        {
            get
            {
                return _tblnaracki;
            }
            set
            {
                if (!object.Equals(_tblnaracki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnaracki", NewValue = value, OldValue = _tblnaracki };
                    _tblnaracki = value;
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
            var bssr4GetTblNarackiByIdResult = await Bssr4.GetTblNarackiById(ID);
            tblnaracki = bssr4GetTblNarackiByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNaracki args)
        {
            try
            {
                var bssr4UpdateTblNarackiResult = await Bssr4.UpdateTblNaracki(ID, tblnaracki);
                DialogService.Close(tblnaracki);
            }
            catch (System.Exception bssr4UpdateTblNarackiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblNaracki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
