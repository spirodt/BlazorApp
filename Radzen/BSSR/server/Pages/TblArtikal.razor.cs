using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace Bssr.Pages
{
    public partial class TblArtikalComponent
    {
        public TblArtikalComponent()
        {
            columns = new[] {
                new ColumnData { Index = 2,ColumnName = "Naziv", Visible = true, Title = "Назив" },
                new ColumnData { Index =3, ColumnName = "Sifra", Visible = false,Title = "Шифра" },
                new ColumnData { Index =1, ColumnName = "AltNaziv", Visible = true,Title = "Алт назив" },
            };
        }
        public bool showIdColumn = true;
        public class ColumnData
        {
            public string ColumnName { get; set; }
            public string Title { get; set; }
            public bool Visible { get; set; }
            public int Index  { get; set; }
    }

        public IEnumerable<ColumnData> columns;

        protected void OnInitialized()
        {
           
        }
        
    }
}
