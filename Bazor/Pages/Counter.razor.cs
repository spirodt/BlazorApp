using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        string[] options = new[]
           {
                "One",
                "Two",
                "Three"
            };
        private string strNewValue = string.Empty;

        Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

        void Click(MouseEventArgs args, string buttonName)
        {
            events.Add(DateTime.Now, $"{buttonName} clicked");
            strNewValue +=events.LastOrDefault().Value;
        }

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
