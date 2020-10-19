using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblSmetkaStavki", Schema = "dbo")]
  public partial class TblSmetkaStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
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
    public int tblNalogID
    {
      get;
      set;
    }
    public TblNalog TblNalog { get; set; }
    public int? Status
    {
      get;
      set;
    }
    public int Kolicina
    {
      get;
      set;
    }
    public decimal Cena
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
