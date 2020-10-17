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

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
