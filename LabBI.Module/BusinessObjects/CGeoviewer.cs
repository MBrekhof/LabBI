using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_GEOVIEWER")]
public partial class CGeoviewer
{
    [Key]
    [Column("GUID")]
    [StringLength(100)]
    public virtual string Guid { get; set; }

    [Column("NAAM")]
    [StringLength(100)]
    public virtual string Naam { get; set; }

    [Column("DATE_CREATED")]
    public virtual DateTime? DateCreated { get; set; }

    [Column("BRANDKRAANNUMMER")]
    [StringLength(100)]
    public virtual string Brandkraannummer { get; set; }

    [Column("BREEDTEGRAAD")]
    public double? Breedtegraad { get; set; }

    [Column("CENTRALE_WACHT_TELNUMMER")]
    [StringLength(100)]
    public virtual string CentraleWachtTelnummer { get; set; }

    [Column("AFDELING")]
    [StringLength(100)]
    public virtual string Afdeling { get; set; }

    [Column("CONTACTPERSOON")]
    [StringLength(100)]
    public virtual string Contactpersoon { get; set; }

    [Column("CONTACTPERSOON_AANNEMER")]
    [StringLength(100)]
    public virtual string ContactpersoonAannemer { get; set; }

    [Column("DATE_CREATED_MONSTERNAME")]
    public virtual DateTime? DateCreatedMonstername { get; set; }

    [Column("EIGENAAR")]
    [StringLength(100)]
    public virtual string Eigenaar { get; set; }

    [Column("FIRMA_NAAM_AANNEMER")]
    [StringLength(100)]
    public virtual string FirmaNaamAannemer { get; set; }

    [Column("FLESNUMMER")]
    [StringLength(100)]
    public virtual string Flesnummer { get; set; }

    [Column("GEMAAKT_DOOR")]
    [StringLength(100)]
    public virtual string GemaaktDoor { get; set; }

    [Column("HERHALING")]
    [StringLength(100)]
    public virtual string Herhaling { get; set; }

    [Column("IN_HET_WEEKEND_BELLEN")]
    [StringLength(100)]
    public virtual string InHetWeekendBellen { get; set; }

    [Column("LABNR_VORIG_MONSTER")]
    [StringLength(100)]
    public virtual string LabnrVorigMonster { get; set; }

    [Column("LEIDING_IN_GEBRUIK")]
    [StringLength(100)]
    public virtual string LeidingInGebruik { get; set; }

    [Column("LENGTEGRAAD")]
    public double? Lengtegraad { get; set; }

    [Column("MONSTER_GENOMEN_UIT")]
    [StringLength(100)]
    public virtual string MonsterGenomenUit { get; set; }

    [Column("MONSTERNAME")]
    [StringLength(100)]
    public virtual string Monstername { get; set; }

    [Column("OPMERKINGEN")]
    public virtual string Opmerkingen { get; set; }

    [Column("ADRES")]
    [StringLength(100)]
    public virtual string Adres { get; set; }

    [Column("PLAATS")]
    [StringLength(100)]
    public virtual string Plaats { get; set; }

    [Column("REDEN_VAN_STATUS")]
    [StringLength(100)]
    public virtual string RedenVanStatus { get; set; }

    [Column("SPOED")]
    [StringLength(100)]
    public virtual string Spoed { get; set; }

    [Column("TEL_AANNEMER")]
    [StringLength(100)]
    public virtual string TelAannemer { get; set; }

    [Column("TYPE_INGREEP")]
    [StringLength(100)]
    public virtual string TypeIngreep { get; set; }

    [Column("VOORZIENINGSGEBIED")]
    [StringLength(100)]
    public virtual string Voorzieningsgebied { get; set; }

    [Column("WACHTDIENST_TELNUMMER")]
    [StringLength(100)]
    public virtual string WachtdienstTelnummer { get; set; }

    [Column("WERKORDER")]
    [StringLength(100)]
    public virtual string Werkorder { get; set; }
}