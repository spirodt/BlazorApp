using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblFiskalniSmetki", Schema = "dbo")]
  public partial class TblFiskalniSmetki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int Broj
    {
      get;
      set;
    }
    public DateTime Datum
    {
      get;
      set;
    }
    public decimal Iznos
    {
      get;
      set;
    }
    public bool? Stornirana
    {
      get;
      set;
    }
    public int tblSmetkaID
    {
      get;
      set;
    }
    public TblSmetka TblSmetka { get; set; }
    public int FirmaID
    {
      get;
      set;
    }
    public string KodNaDokument
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
