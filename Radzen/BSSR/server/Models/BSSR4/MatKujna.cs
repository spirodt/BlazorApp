using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("matKujna", Schema = "dbo")]
  public partial class MatKujna
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
    public int? Artikal
    {
      get;
      set;
    }
  }
}
