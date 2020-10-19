﻿using System;
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
    public partial class AddTblLogComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblSesija> _getTblSesijasForSesijaResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblSesija> getTblSesijasForSesijaResult
        {
            get
            {
                return _getTblSesijasForSesijaResult;
            }
            set
            {
                if (!object.Equals(_getTblSesijasForSesijaResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblSesijasForSesijaResult", NewValue = value, OldValue = _getTblSesijasForSesijaResult };
                    _getTblSesijasForSesijaResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblLog _tbllog;
        protected Bssr.Models.Bssr4.TblLog tbllog
        {
            get
            {
                return _tbllog;
            }
            set
            {
                if (!object.Equals(_tbllog, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tbllog", NewValue = value, OldValue = _tbllog };
                    _tbllog = value;
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
            var bssr4GetTblSesijasResult = await Bssr4.GetTblSesijas();
            getTblSesijasForSesijaResult = bssr4GetTblSesijasResult;

            tbllog = new Bssr.Models.Bssr4.TblLog(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblLog args)
        {
            try
            {
                var bssr4CreateTblLogResult = await Bssr4.CreateTblLog(tbllog);
                DialogService.Close(tbllog);
            }
            catch (System.Exception bssr4CreateTblLogException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblLog!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
