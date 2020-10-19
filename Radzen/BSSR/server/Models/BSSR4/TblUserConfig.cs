using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblUserConfigs", Schema = "dbo")]
  public partial class TblUserConfig
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int UserID
    {
      get;
      set;
    }
    public TblUser TblUser { get; set; }
    public string ObjectName
    {
      get;
      set;
    }
    public string ConfigData
    {
      get;
      set;
    }
    public DateTime DateOfCreation
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
