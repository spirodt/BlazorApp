using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblIzvodi", Schema = "dbo")]
  public partial class TblIzvodi
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblIzvodiStavki> TblIzvodiStavkis { get; set; }
    public string BrojNaIzvod
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public string Smetka
    {
      get;
      set;
    }
    public DateTime? DatumNaIzvod
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
