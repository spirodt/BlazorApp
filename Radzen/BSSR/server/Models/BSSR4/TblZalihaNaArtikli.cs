using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblZalihaNaArtikli", Schema = "dbo")]
  public partial class TblZalihaNaArtikli
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public DateTime Datum
    {
      get;
      set;
    }
    public int tblArtikalID
    {
      get;
      set;
    }
    public decimal Vlez
    {
      get;
      set;
    }
    public decimal Izlez
    {
      get;
      set;
    }
    public int TIpDokument
    {
      get;
      set;
    }
    public int IDNaDokument
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
