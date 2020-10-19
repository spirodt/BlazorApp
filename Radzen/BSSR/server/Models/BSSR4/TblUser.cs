using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblUsers", Schema = "dbo")]
  public partial class TblUser
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblFaktura> TblFakturas { get; set; }
    public ICollection<TblSmetka> TblSmetkas { get; set; }
    public ICollection<TblUserConfig> TblUserConfigs { get; set; }
    public string UserName
    {
      get;
      set;
    }
    public string Password
    {
      get;
      set;
    }
    public string FullName
    {
      get;
      set;
    }
    public int NivoNaAdministracija
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
    public int? tblObjektId
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
