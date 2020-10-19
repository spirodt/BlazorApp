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
    public partial class AddTblSmetkaComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblFirma> _getTblFirmasForFirmaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblFirma> getTblFirmasForFirmaIDResult
        {
            get
            {
                return _getTblFirmasForFirmaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblFirmasForFirmaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblFirmasForFirmaIDResult", NewValue = value, OldValue = _getTblFirmasForFirmaIDResult };
                    _getTblFirmasForFirmaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblObjekti> _getTblObjektisForObjektIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblObjekti> getTblObjektisForObjektIDResult
        {
            get
            {
                return _getTblObjektisForObjektIDResult;
            }
            set
            {
                if (!object.Equals(_getTblObjektisForObjektIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblObjektisForObjektIDResult", NewValue = value, OldValue = _getTblObjektisForObjektIDResult };
                    _getTblObjektisForObjektIDResult = value;
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

        Bssr.Models.Bssr4.TblSmetka _tblsmetka;
        protected Bssr.Models.Bssr4.TblSmetka tblsmetka
        {
            get
            {
                return _tblsmetka;
            }
            set
            {
                if (!object.Equals(_tblsmetka, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblsmetka", NewValue = value, OldValue = _tblsmetka };
                    _tblsmetka = value;
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
            var bssr4GetTblUsersResult = await Bssr4.GetTblUsers();
            getTblUsersFortblUserIDResult = bssr4GetTblUsersResult;

            var bssr4GetTblFirmasResult = await Bssr4.GetTblFirmas();
            getTblFirmasForFirmaIDResult = bssr4GetTblFirmasResult;

            var bssr4GetTblObjektisResult = await Bssr4.GetTblObjektis();
            getTblObjektisForObjektIDResult = bssr4GetTblObjektisResult;

            var bssr4GetTblPartnerisResult = await Bssr4.GetTblPartneris();
            getTblPartnerisFortblPartnerIDResult = bssr4GetTblPartnerisResult;

            tblsmetka = new Bssr.Models.Bssr4.TblSmetka(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblSmetka args)
        {
            try
            {
                var bssr4CreateTblSmetkaResult = await Bssr4.CreateTblSmetka(tblsmetka);
                DialogService.Close(tblsmetka);
            }
            catch (System.Exception bssr4CreateTblSmetkaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSmetka!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
