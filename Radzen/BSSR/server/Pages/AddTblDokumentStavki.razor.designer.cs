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
    public partial class AddTblDokumentStavkiComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblDokumenti> _getTblDokumentisFortblDokumentIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblDokumenti> getTblDokumentisFortblDokumentIDResult
        {
            get
            {
                return _getTblDokumentisFortblDokumentIDResult;
            }
            set
            {
                if (!object.Equals(_getTblDokumentisFortblDokumentIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblDokumentisFortblDokumentIDResult", NewValue = value, OldValue = _getTblDokumentisFortblDokumentIDResult };
                    _getTblDokumentisFortblDokumentIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblDokumentStavki _tbldokumentstavki;
        protected Bssr.Models.Bssr4.TblDokumentStavki tbldokumentstavki
        {
            get
            {
                return _tbldokumentstavki;
            }
            set
            {
                if (!object.Equals(_tbldokumentstavki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbldokumentstavki", NewValue = value, OldValue = _tbldokumentstavki };
                    _tbldokumentstavki = value;
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
            var bssr4GetTblDokumentisResult = await Bssr4.GetTblDokumentis();
            getTblDokumentisFortblDokumentIDResult = bssr4GetTblDokumentisResult;

            tbldokumentstavki = new Bssr.Models.Bssr4.TblDokumentStavki(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblDokumentStavki args)
        {
            try
            {
                var bssr4CreateTblDokumentStavkiResult = await Bssr4.CreateTblDokumentStavki(tbldokumentstavki);
                DialogService.Close(tbldokumentstavki);
            }
            catch (System.Exception bssr4CreateTblDokumentStavkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblDokumentStavki!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
