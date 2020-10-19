using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNetworkPCLOG", Schema = "dbo")]
  public partial class TblNetworkPclog
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string Akcija
    {
      get;
      set;
    }
    public int? tblNetworkPCID
    {
      get;
      set;
    }
    public DateTime? Datum
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
    [Timestamp]
    public Byte[] DataVersion
    {
      get;
      set;
    }
  }
}
