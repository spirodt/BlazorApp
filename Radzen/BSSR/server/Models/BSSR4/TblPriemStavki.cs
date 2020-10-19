using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPriemStavki", Schema = "dbo")]
  public partial class TblPriemStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblPriemID
    {
      get;
      set;
    }
    public TblPriem TblPriem { get; set; }
    public int tblArtikalID
    {
      get;
      set;
    }
    public TblArtikal TblArtikal { get; set; }
    public decimal Kolicina
    {
      get;
      set;
    }
    public decimal NabavnaCenaBezDDV
    {
      get;
      set;
    }
    public decimal NabavnaCenaSoDDV
    {
      get;
      set;
    }
    public decimal? Rabat1
    {
      get;
      set;
    }
    public decimal? Rabat2
    {
      get;
      set;
    }
    public decimal? Rabat3
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
