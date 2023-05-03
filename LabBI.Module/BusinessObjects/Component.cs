using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;


[PrimaryKey("Analysis", "Name", "Version")]
[Table("COMPONENT")]
//[Index("Analysis", Name = "COMPONENT_ANA13302")]
//[Index("Name", Name = "COMPONENT_NAM11051")]
//[Index("Units", Name = "COMPONENT_UNIT9125")]
[DefaultClassOptions]
[NavigationItem("Analysis")]
[DefaultProperty("NAME")]
public   class Component : BaseObjectNoID
{
    [Key]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Analysis { get; set; }

    [Key]
    [Column("NAME")]
    [StringLength(60)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Key]
    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("RESULT_TYPE")]
    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ResultType { get; set; }

    [Column("UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Units { get; set; }

    [Column("MINIMUM")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Minimum { get; set; }

    [Column("MAXIMUM")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Maximum { get; set; }

    [Column("ALLOW_OUT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowOut { get; set; }

    [Column("PLACES")]
    public virtual int? Places { get; set; }

    [Column("NUM_REPLICATES")]
    public virtual int? NumReplicates { get; set; }

    [Column("USES_INSTRUMENT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UsesInstrument { get; set; }

    [Column("USES_CODES")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UsesCodes { get; set; }

    [Column("AUTO_CALC")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AutoCalc { get; set; }

    [Column("LIST_KEY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ListKey { get; set; }

    [Column("ALLOW_CANCEL")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowCancel { get; set; }

    [Column("CAS_NUMBER")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CasNumber { get; set; }

    [Column("ALIAS_NAME")]
    [StringLength(40)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AliasName { get; set; }

    [Column("REPORTABLE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Reportable { get; set; }

    [Column("OPTIONAL")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Optional { get; set; }

    [Column("ROUND")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Round { get; set; }

    [Column("CLAMP_LOW")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ClampLow { get; set; }

    [Column("CLAMP_HIGH")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ClampHigh { get; set; }

    [Column("STD_REAG_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StdReagTemplate { get; set; }

    [Column("HAS_ATTRIBUTES")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string HasAttributes { get; set; }

    [Column("FORMAT_CALCULATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FormatCalculation { get; set; }

    [Column("DISPLAYED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Displayed { get; set; }

    [Column("VERSION_FILES")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string VersionFiles { get; set; }

    [Column("BROWSE_SUBROUTINE")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BrowseSubroutine { get; set; }

    [Column("STEP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Step { get; set; }

    [Column("NWA_NAME")]
    [StringLength(32)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NwaName { get; set; }

    [Column("PLACES_2")]
    public virtual int? Places2 { get; set; }

    [Column("REPORTED_RESULT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportedResult { get; set; }

    [Column("CONVERSION_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ConversionType { get; set; }

    [Column("FROM_CATEGORY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FromCategory { get; set; }

    [Column("TO_CATEGORY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ToCategory { get; set; }

    [Column("FROM_UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FromUnits { get; set; }

    [Column("TO_UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ToUnits { get; set; }

    [Column("CONVERSION_FACTOR")]
    public virtual float? ConversionFactor { get; set; }

    [Column("T_SHORT_NAME")]
    [StringLength(17)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TShortName { get; set; }

    [Column("T_MDL")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TMdl { get; set; }

    [Column("T_MRL")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TMrl { get; set; }

    [Column("REPORTED_NAME")]
    [StringLength(60)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportedName { get; set; }

    [Column("C_SIKB_CODE")]
    public virtual int? CSikbCode { get; set; }

    [Column("C_REWAB_CODE")]
    public virtual int? CRewabCode { get; set; }

    [Column("C_CADRI_CODE")]
    [StringLength(12)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CCadriCode { get; set; }
}