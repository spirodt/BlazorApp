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
    public partial class EditTblSmetkaStavkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblSmetkaStavki _tblsmetkastavki;
        protected Bssr.Models.Bssr4.TblSmetkaStavki tblsmetkastavki
        {
            get
            {
                return _tblsmetkastavki;
            }
            set
            {
                if (!object.Equals(_tblsmetkastavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblsmetkastavki", NewValue = value, OldValue = _tblsmetkastavki };
                    _tblsmetkastavki = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblSmetka> _getTblSmetkasFortblSmetkaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblSmetka> getTblSmetkasFortblSmetkaIDResult
        {
            get
            {
                return _getTblSmetkasFortblSmetkaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblSmetkasFortblSmetkaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblSmetkasFortblSmetkaIDResult", NewValue = value, OldValue = _getTblSmetkasFortblSmetkaIDResult };
                    _getTblSmetkasFortblSmetkaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblNalog> _getTblNalogsFortblNalogIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNalog> getTblNalogsFortblNalogIDResult
        {
            get
            {
                return _getTblNalogsFortblNalogIDResult;
            }
            set
            {
                if (!object.Equals(_getTblNalogsFortblNalogIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNalogsFortblNalogIDResult", NewValue = value, OldValue = _getTblNalogsFortblNalogIDResult };
                    _getTblNalogsFortblNalogIDResult = value;
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
            var bssr4GetTblSmetkaStavkiByIdResult = await Bssr4.GetTblSmetkaStavkiById(ID);
            tblsmetkastavki = bssr4GetTblSmetkaStavkiByIdResult;

            var bssr4GetTblSmetkasResult = await Bssr4.GetTblSmetkas();
            getTblSmetkasFortblSmetkaIDResult = bssr4GetTblSmetkasResult;

            var bssr4GetTblNalogsResult = await Bssr4.GetTblNalogs();
            getTblNalogsFortblNalogIDResult = bssr4GetTblNalogsResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblSmetkaStavki args)
        {
            try
            {
                var bssr4UpdateTblSmetkaStavkiResult = await Bssr4.UpdateTblSmetkaStavki(ID, tblsmetkastavki);
                DialogService.Close(tblsmetkastavki);
            }
            catch (System.Exception bssr4UpdateTblSmetkaStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSmetkaStavki");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
