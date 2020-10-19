using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblElektronskoPracanje", Schema = "dbo")]
  public partial class TblElektronskoPracanje
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int DokumentID
    {
      get;
      set;
    }
    public string Naziv
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public string DokumentValue
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
    public string PratenOD
    {
      get;
      set;
    }
    public string PratenDO
    {
      get;
      set;
    }
    public DateTime DatumNaPracanje
    {
      get;
      set;
    }
    public DateTime? DatumNaPoslednaIzmenaNaStatus
    {
      get;
      set;
    }
    public bool PratenPrimen
    {
      get;
      set;
    }
    public DateTime? DatumNaPotvrda
    {
      get;
      set;
    }
    public DateTime? DatumNaKnizenje
    {
      get;
      set;
    }
    public string GeneriranKodNaDokument
    {
      get;
      set;
    }
    public int ODObjekt
    {
      get;
      set;
    }
    public int DoObjekt
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
