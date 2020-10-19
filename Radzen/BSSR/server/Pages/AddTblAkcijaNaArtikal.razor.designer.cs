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
    public partial class AddTblAkcijaNaArtikalComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblArtikal> _getTblArtikalsFortblArtikalIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblArtikal> getTblArtikalsFortblArtikalIDResult
        {
            get
            {
                return _getTblArtikalsFortblArtikalIDResult;
            }
            set
            {
                if (!object.Equals(_getTblArtikalsFortblArtikalIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblArtikalsFortblArtikalIDResult", NewValue = value, OldValue = _getTblArtikalsFortblArtikalIDResult };
                    _getTblArtikalsFortblArtikalIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblAkcijaNaArtikal _tblakcijanaartikal;
        protected Bssr.Models.Bssr4.TblAkcijaNaArtikal tblakcijanaartikal
        {
            get
            {
                return _tblakcijanaartikal;
            }
            set
            {
                if (!object.Equals(_tblakcijanaartikal, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblakcijanaartikal", NewValue = value, OldValue = _tblakcijanaartikal };
                    _tblakcijanaartikal = value;
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
            var bssr4GetTblArtikalsResult = await Bssr4.GetTblArtikals();
            getTblArtikalsFortblArtikalIDResult = bssr4GetTblArtikalsResult;

            tblakcijanaartikal = new Bssr.Models.Bssr4.TblAkcijaNaArtikal(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblAkcijaNaArtikal args)
        {
            try
            {
                var bssr4CreateTblAkcijaNaArtikalResult = await Bssr4.CreateTblAkcijaNaArtikal(tblakcijanaartikal);
                DialogService.Close(tblakcijanaartikal);
            }
            catch (System.Exception bssr4CreateTblAkcijaNaArtikalException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblAkcijaNaArtikal!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
