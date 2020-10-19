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
    public partial class EditTblIzvodiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblIzvodi _tblizvodi;
        protected Bssr.Models.Bssr4.TblIzvodi tblizvodi
        {
            get
            {
                return _tblizvodi;
            }
            set
            {
                if (!object.Equals(_tblizvodi, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblizvodi", NewValue = value, OldValue = _tblizvodi };
                    _tblizvodi = value;
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
            var bssr4GetTblIzvodiByIdResult = await Bssr4.GetTblIzvodiById(ID);
            tblizvodi = bssr4GetTblIzvodiByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblIzvodi args)
        {
            try
            {
                var bssr4UpdateTblIzvodiResult = await Bssr4.UpdateTblIzvodi(ID, tblizvodi);
                DialogService.Close(tblizvodi);
            }
            catch (System.Exception bssr4UpdateTblIzvodiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIzvodi");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
