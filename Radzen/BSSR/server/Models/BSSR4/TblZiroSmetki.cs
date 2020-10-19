using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblZiroSmetki", Schema = "dbo")]
  public partial class TblZiroSmetki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblFaktura> TblFakturas { get; set; }
    public string ZiroSmetka
    {
      get;
      set;
    }
    public int tblPartnerID
    {
      get;
      set;
    }
    public int tblBankaID
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public string Status
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
