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
    public partial class EditTblObjektiComponent : ComponentBase
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

        Bssr.Models.Bssr4.TblObjekti _tblobjekti;
        protected Bssr.Models.Bssr4.TblObjekti tblobjekti
        {
            get
            {
                return _tblobjekti;
            }
            set
            {
                if (!object.Equals(_tblobjekti, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblobjekti", NewValue = value, OldValue = _tblobjekti };
                    _tblobjekti = value;
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
            var bssr4GetTblObjektiByIdResult = await Bssr4.GetTblObjektiById(ID);
            tblobjekti = bssr4GetTblObjektiByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblObjekti args)
        {
            try
            {
                var bssr4UpdateTblObjektiResult = await Bssr4.UpdateTblObjekti(ID, tblobjekti);
                DialogService.Close(tblobjekti);
            }
            catch (System.Exception bssr4UpdateTblObjektiException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblObjekti");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
