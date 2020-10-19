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
    public partial class EditTblPriemComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblPriem _tblpriem;
        protected Bssr.Models.Bssr4.TblPriem tblpriem
        {
            get
            {
                return _tblpriem;
            }
            set
            {
                if (!object.Equals(_tblpriem, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblpriem", NewValue = value, OldValue = _tblpriem };
                    _tblpriem = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPartneri> _getTblPartnerisFortblPartnerIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPartneri> getTblPartnerisFortblPartnerIDResult
        {
            get
            {
                return _getTblPartnerisFortblPartnerIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPartnerisFortblPartnerIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPartnerisFortblPartnerIDResult", NewValue = value, OldValue = _getTblPartnerisFortblPartnerIDResult };
                    _getTblPartnerisFortblPartnerIDResult = value;
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
            var bssr4GetTblPriemByIdResult = await Bssr4.GetTblPriemById(ID);
            tblpriem = bssr4GetTblPriemByIdResult;

            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris();
            getTblPartnerisFortblPartnerIDResult = bssr4GetTblPartnerisResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPriem args)
        {
            try
            {
                var bssr4UpdateTblPriemResult = await Bssr4.UpdateTblPriem(ID, tblpriem);
                DialogService.Close(tblpriem);
            }
            catch (System.Exception bssr4UpdateTblPriemException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPriem");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
