using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblFakturaStavki", Schema = "dbo")]
  public partial class TblFakturaStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblFakturaID
    {
      get;
      set;
    }
    public TblFaktura TblFaktura { get; set; }
    public int tblArtikalID
    {
      get;
      set;
    }
    public bool Normativ
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
