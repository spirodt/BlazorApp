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
    public partial class EditTblPartneriComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblPartneri _tblpartneri;
        protected Bssr.Models.Bssr4.TblPartneri tblpartneri
        {
            get
            {
                return _tblpartneri;
            }
            set
            {
                if (!object.Equals(_tblpartneri, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblpartneri", NewValue = value, OldValue = _tblpartneri };
                    _tblpartneri = value;
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
            var bssr4GetTblPartneriByIdResult = await Bssr4.GetTblPartneriById(ID);
            tblpartneri = bssr4GetTblPartneriByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPartneri args)
        {
            try
            {
                var bssr4UpdateTblPartneriResult = await Bssr4.UpdateTblPartneri(ID, tblpartneri);
                DialogService.Close(tblpartneri);
            }
            catch (System.Exception bssr4UpdateTblPartneriException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPartneri");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
