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
    public partial class EditTblConfigComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblConfig _tblconfig;
        protected Bssr.Models.Bssr4.TblConfig tblconfig
        {
            get
            {
                return _tblconfig;
            }
            set
            {
                if (!object.Equals(_tblconfig, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblconfig", NewValue = value, OldValue = _tblconfig };
                    _tblconfig = value;
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
            var bssr4GetTblConfigByIdResult = await Bssr4.GetTblConfigById(ID);
            tblconfig = bssr4GetTblConfigByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblConfig args)
        {
            try
            {
                var bssr4UpdateTblConfigResult = await Bssr4.UpdateTblConfig(ID, tblconfig);
                DialogService.Close(tblconfig);
            }
            catch (System.Exception bssr4UpdateTblConfigException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblConfig");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
