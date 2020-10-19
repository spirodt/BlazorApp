using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblConfig", Schema = "dbo")]
  public partial class TblConfig
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string Opis
    {
      get;
      set;
    }
    public string Ime
    {
      get;
      set;
    }
    public int? Vrednost
    {
      get;
      set;
    }
    public int? NivoNaAdministracija
    {
      get;
      set;
    }
    public string Range
    {
      get;
      set;
    }
    public string ImeNaModul
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
