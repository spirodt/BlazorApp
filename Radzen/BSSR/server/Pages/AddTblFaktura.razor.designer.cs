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
    public partial class AddTblFakturaComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblZiroSmetki> _getTblZiroSmetkisFortblZiroSmetkaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblZiroSmetki> getTblZiroSmetkisFortblZiroSmetkaIDResult
        {
            get
            {
                return _getTblZiroSmetkisFortblZiroSmetkaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblZiroSmetkisFortblZiroSmetkaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblZiroSmetkisFortblZiroSmetkaIDResult", NewValue = value, OldValue = _getTblZiroSmetkisFortblZiroSmetkaIDResult };
                    _getTblZiroSmetkisFortblZiroSmetkaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblBanki> _getTblBankisFortblBankaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblBanki> getTblBankisFortblBankaIDResult
        {
            get
            {
                return _getTblBankisFortblBankaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblBankisFortblBankaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblBankisFortblBankaIDResult", NewValue = value, OldValue = _getTblBankisFortblBankaIDResult };
                    _getTblBankisFortblBankaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblUser> _getTblUsersFortblUserIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblUser> getTblUsersFortblUserIDResult
        {
            get
            {
                return _getTblUsersFortblUserIDResult;
            }
            set
            {
                if (!object.Equals(_getTblUsersFortblUserIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblUsersFortblUserIDResult", NewValue = value, OldValue = _getTblUsersFortblUserIDResult };
                    _getTblUsersFortblUserIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblFaktura _tblfaktura;
        protected Bssr.Models.Bssr4.TblFaktura tblfaktura
        {
            get
            {
                return _tblfaktura;
            }
            set
            {
                if (!object.Equals(_tblfaktura, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblfaktura", NewValue = value, OldValue = _tblfaktura };
                    _tblfaktura = value;
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
            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris();
            getTblPartnerisFortblPartnerIDResult = bssr4GetTblPartnerisResult;

            var bssr4GetTblZiroSmetkisResult = await Bssr4.GetTblZiroSmetkis();
            getTblZiroSmetkisFortblZiroSmetkaIDResult = bssr4GetTblZiroSmetkisResult;

            var bssr4GetTblBankisResult = await Bssr4.GetTblBankis();
            getTblBankisFortblBankaIDResult = bssr4GetTblBankisResult;

            var bssr4GetTblUsersResult = await Bssr4.GetTblUsers();
            getTblUsersFortblUserIDResult = bssr4GetTblUsersResult;

            tblfaktura = new Bssr.Models.Bssr4.TblFaktura(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblFaktura args)
        {
            try
            {
                var bssr4CreateTblFakturaResult = await Bssr4.CreateTblFaktura(tblfaktura);
                DialogService.Close(tblfaktura);
            }
            catch (System.Exception bssr4CreateTblFakturaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblFaktura!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
