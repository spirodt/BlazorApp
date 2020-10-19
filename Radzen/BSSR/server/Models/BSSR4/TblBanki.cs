using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblBanki", Schema = "dbo")]
  public partial class TblBanki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblFaktura> TblFakturas { get; set; }
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
    public int? Status
    {
      get;
      set;
    }
    public int FirmaID
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
