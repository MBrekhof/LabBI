using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_CNTRL_CRT_DATA")]
public partial class CCntrlCrtData
{
    [Key]
    [Column("ENTRY_CODE")]
    public virtual int EntryCode { get; set; }

    [Column("CHART_NUM")]
    public virtual int? ChartNum { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("DATE_ANALYSIS", TypeName = "datetime")]
    public virtual DateTime? DateAnalysis { get; set; }

    [Column("OPERATOR")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Operator { get; set; }

    [Column("RESULT_VAL")]
    public virtual float? ResultVal { get; set; }

    [Column("UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Units { get; set; }

    [Column("TEST_LOCATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestLocation { get; set; }

    [Column("CURR_AVG")]
    public virtual float? CurrAvg { get; set; }

    [Column("CURR_STD")]
    public virtual float? CurrStd { get; set; }

    [Column("INCLUDED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Included { get; set; }

    [Column("RESULT_NUMBER")]
    public virtual int? ResultNumber { get; set; }

    [Column("DEVIATION")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Deviation { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("INVESTIGATION")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Investigation { get; set; }

    [Column("C_CNTRL_CHART")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CCntrlChart { get; set; }

    [Column("REMARK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Remark { get; set; }
}