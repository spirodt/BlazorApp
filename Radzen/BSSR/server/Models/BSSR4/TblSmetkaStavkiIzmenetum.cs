using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblSmetkaStavkiIzmeneta", Schema = "dbo")]
  public partial class TblSmetkaStavkiIzmenetum
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
    public int tblNalogID
    {
      get;
      set;
    }
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
    public DateTime? DatumNaIzmena
    {
      get;
      set;
    }
    public int? tblSmetkaIzmenetaID
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
