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
    public partial class AddTblNormativComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNormativ _tblnormativ;
        protected Bssr.Models.Bssr4.TblNormativ tblnormativ
        {
            get
            {
                return _tblnormativ;
            }
            set
            {
                if (!object.Equals(_tblnormativ, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnormativ", NewValue = value, OldValue = _tblnormativ };
                    _tblnormativ = value;
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
            var bssr4GetTblFirmasResult = await Bssr4.GetTblFirmas();
            getTblFirmasForFirmaIDResult = bssr4GetTblFirmasResult;

            tblnormativ = new Bssr.Models.Bssr4.TblNormativ(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNormativ args)
        {
            try
            {
                var bssr4CreateTblNormativResult = await Bssr4.CreateTblNormativ(tblnormativ);
                DialogService.Close(tblnormativ);
            }
            catch (System.Exception bssr4CreateTblNormativException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblNormativ!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
