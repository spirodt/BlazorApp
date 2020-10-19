using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNalogStavki", Schema = "dbo")]
  public partial class TblNalogStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblNalogID
    {
      get;
      set;
    }
    public TblNalog TblNalog { get; set; }
    public int? tblNomativID
    {
      get;
      set;
    }
    public TblNormativ TblNormativ { get; set; }
    public int? tblArtikalID
    {
      get;
      set;
    }
    public TblArtikal TblArtikal { get; set; }
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
