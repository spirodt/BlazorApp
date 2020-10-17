using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class FetchData
    {
        [Inject] WeatherForecastService ForecastService { get; set; }
        WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

        }
    }
}
