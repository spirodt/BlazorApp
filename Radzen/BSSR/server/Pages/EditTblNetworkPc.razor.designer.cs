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
    public partial class EditTblNetworkPcComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblNetworkPc _tblnetworkpc;
        protected Bssr.Models.Bssr4.TblNetworkPc tblnetworkpc
        {
            get
            {
                return _tblnetworkpc;
            }
            set
            {
                if (!object.Equals(_tblnetworkpc, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblnetworkpc", NewValue = value, OldValue = _tblnetworkpc };
                    _tblnetworkpc = value;
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
            var bssr4GetTblNetworkPcByIdResult = await Bssr4.GetTblNetworkPcById(ID);
            tblnetworkpc = bssr4GetTblNetworkPcByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblNetworkPc args)
        {
            try
            {
                var bssr4UpdateTblNetworkPcResult = await Bssr4.UpdateTblNetworkPc(ID, tblnetworkpc);
                DialogService.Close(tblnetworkpc);
            }
            catch (System.Exception bssr4UpdateTblNetworkPcException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblNetworkPc");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
