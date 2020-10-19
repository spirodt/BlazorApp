using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblAkcijaNaArtikal", Schema = "dbo")]
  public partial class TblAkcijaNaArtikal
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public DateTime DatumPocetok
    {
      get;
      set;
    }
    public DateTime DatumKraj
    {
      get;
      set;
    }
    public int tblArtikalID
    {
      get;
      set;
    }
    public TblArtikal TblArtikal { get; set; }
    public decimal AkciskaCena
    {
      get;
      set;
    }
    public decimal? Rabat
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
