using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPresmetkovniEdinici", Schema = "dbo")]
  public partial class TblPresmetkovniEdinici
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string Sifra
    {
      get;
      set;
    }
    public string Naziv
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public int? Status
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
