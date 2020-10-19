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
    public partial class AddTblNalogComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNalog _tblnalog;
        protected Bssr.Models.Bssr4.TblNalog tblnalog
        {
            get
            {
                return _tblnalog;
            }
            set
            {
                if (!object.Equals(_tblnalog, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnalog", NewValue = value, OldValue = _tblnalog };
                    _tblnalog = value;
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

            tblnalog = new Bssr.Models.Bssr4.TblNalog(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNalog args)
        {
            try
            {
                var bssr4CreateTblNalogResult = await Bssr4.CreateTblNalog(tblnalog);
                DialogService.Close(tblnalog);
            }
            catch (System.Exception bssr4CreateTblNalogException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblNalog!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
