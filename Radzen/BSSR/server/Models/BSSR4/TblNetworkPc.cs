using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNetworkPC", Schema = "dbo")]
  public partial class TblNetworkPc
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string PCName
    {
      get;
      set;
    }
    public string HostName
    {
      get;
      set;
    }
    public string IPAddres
    {
      get;
      set;
    }
    public int? Number
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public int? FirmaID
    {
      get;
      set;
    }
    public DateTime? StartTime
    {
      get;
      set;
    }
    public DateTime? EndTime
    {
      get;
      set;
    }
    public int? PoslednaSmetka
    {
      get;
      set;
    }
    public int? tblArtikalID
    {
      get;
      set;
    }
    public string R_UserName
    {
      get;
      set;
    }
    public string R_PassWord
    {
      get;
      set;
    }
    public string ClientPassword
    {
      get;
      set;
    }
    public string Grupa
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
