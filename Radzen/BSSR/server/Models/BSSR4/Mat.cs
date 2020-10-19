using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("mat", Schema = "dbo")]
  public partial class Mat
  {
    public string Naziv
    {
      get;
      set;
    }
    public decimal? Kolicina
    {
      get;
      set;
    }
    public decimal? Iznos
    {
      get;
      set;
    }
    public decimal? ProdaznaCena
    {
      get;
      set;
    }
    public string Sifra
    {
      get;
      set;
    }
    public int? NalogID
    {
      get;
      set;
    }
    public int? Artikal
    {
      get;
      set;
    }
    public int? Tip
    {
      get;
      set;
    }
  }
}
