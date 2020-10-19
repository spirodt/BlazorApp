using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblDokumentStavki", Schema = "dbo")]
  public partial class TblDokumentStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblDokumentID
    {
      get;
      set;
    }
    public TblDokumenti TblDokumenti { get; set; }
    public int? tblArtikalID
    {
      get;
      set;
    }
    public int? tblNormativID
    {
      get;
      set;
    }
    public decimal Cena
    {
      get;
      set;
    }
    public decimal Kolicina
    {
      get;
      set;
    }
    public decimal Iznos
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
