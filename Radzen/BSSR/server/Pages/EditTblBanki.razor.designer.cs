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
    public partial class EditTblBankiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblBanki _tblbanki;
        protected Bssr.Models.Bssr4.TblBanki tblbanki
        {
            get
            {
                return _tblbanki;
            }
            set
            {
                if (!object.Equals(_tblbanki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblbanki", NewValue = value, OldValue = _tblbanki };
                    _tblbanki = value;
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
            var bssr4GetTblBankiByIdResult = await Bssr4.GetTblBankiById(ID);
            tblbanki = bssr4GetTblBankiByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblBanki args)
        {
            try
            {
                var bssr4UpdateTblBankiResult = await Bssr4.UpdateTblBanki(ID, tblbanki);
                DialogService.Close(tblbanki);
            }
            catch (System.Exception bssr4UpdateTblBankiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblBanki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
