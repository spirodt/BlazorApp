using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNalogStavkiIzmeneta", Schema = "dbo")]
  public partial class TblNalogStavkiIzmenetum
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblNalogIzmenetaID
    {
      get;
      set;
    }
    public int? tblNomativID
    {
      get;
      set;
    }
    public int? tblArtikalID
    {
      get;
      set;
    }
    public decimal? Kolicina
    {
      get;
      set;
    }
    public decimal? Rabat1
    {
      get;
      set;
    }
    [Timestamp]
    public Byte[] DataVersion
    {
      get;
      set;
    }
  }
}
