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
    public partial class AddTblFiskalniSmetkiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblFiskalniSmetki _tblfiskalnismetki;
        protected Bssr.Models.Bssr4.TblFiskalniSmetki tblfiskalnismetki
        {
            get
            {
                return _tblfiskalnismetki;
            }
            set
            {
                if (!object.Equals(_tblfiskalnismetki, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblfiskalnismetki", NewValue = value, OldValue = _tblfiskalnismetki };
                    _tblfiskalnismetki = value;
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
            var bssr4GetTblSmetkasResult = await Bssr4.GetTblSmetkas();
            getTblSmetkasFortblSmetkaIDResult = bssr4GetTblSmetkasResult;

            tblfiskalnismetki = new Bssr.Models.Bssr4.TblFiskalniSmetki(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblFiskalniSmetki args)
        {
            try
            {
                var bssr4CreateTblFiskalniSmetkiResult = await Bssr4.CreateTblFiskalniSmetki(tblfiskalnismetki);
                DialogService.Close(tblfiskalnismetki);
            }
            catch (System.Exception bssr4CreateTblFiskalniSmetkiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblFiskalniSmetki!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
