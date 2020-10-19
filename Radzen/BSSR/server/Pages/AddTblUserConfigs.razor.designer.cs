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
    public partial class AddTblUserConfigsComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblUser> _getTblUsersForUserIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblUser> getTblUsersForUserIDResult
        {
            get
            {
                return _getTblUsersForUserIDResult;
            }
            set
            {
                if (!object.Equals(_getTblUsersForUserIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblUsersForUserIDResult", NewValue = value, OldValue = _getTblUsersForUserIDResult };
                    _getTblUsersForUserIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblUserConfig _tbluserconfig;
        protected Bssr.Models.Bssr4.TblUserConfig tbluserconfig
        {
            get
            {
                return _tbluserconfig;
            }
            set
            {
                if (!object.Equals(_tbluserconfig, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbluserconfig", NewValue = value, OldValue = _tbluserconfig };
                    _tbluserconfig = value;
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
            getTblUsersForUserIDResult = bssr4GetTblUsersResult;

            tbluserconfig = new Bssr.Models.Bssr4.TblUserConfig(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblUserConfig args)
        {
            try
            {
                var bssr4CreateTblUserConfigResult = await Bssr4.CreateTblUserConfig(tbluserconfig);
                DialogService.Close(tbluserconfig);
            }
            catch (System.Exception bssr4CreateTblUserConfigException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblUserConfig!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
