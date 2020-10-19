using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNormativStavki", Schema = "dbo")]
  public partial class TblNormativStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblNormativID
    {
      get;
      set;
    }
    public TblNormativ TblNormativ { get; set; }
    public int tblArtikalID
    {
      get;
      set;
    }
    public TblArtikal TblArtikal { get; set; }
    public int? Status
    {
      get;
      set;
    }
    public decimal Kolicina
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
