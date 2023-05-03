using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("Name", "Analysis", "AnalysisCount")]
[Table("TEST_LIST_ENTRY")]
//[Index("Analysis", Name = "idx_TEST_LIST_ENTRY_ANALYSIS")]
public  partial class TestListEntry: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Key]
    [Column("ANALYSIS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("STD_TEST")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StdTest { get; set; }

    [Column("REPLICATE_COUNT")]
    public virtual int? ReplicateCount { get; set; }

    [Column("PARAMETER_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParameterName { get; set; }

    [Column("PARAMETER_VALUE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParameterValue { get; set; }

    [Column("TEST_PRIORITY")]
    public virtual int? TestPriority { get; set; }

    [Column("INSTRUMENT")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Instrument { get; set; }

    [Column("TEST_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestLocation { get; set; }

    [Column("ASSIGN_IF_PRESENT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AssignIfPresent { get; set; }

    [Column("VARIATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Variation { get; set; }

    [Key]
    [Column("ANALYSIS_COUNT")]
    public virtual int AnalysisCount { get; set; }

    [Column("REPORTED_NAME")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportedName { get; set; }

    [Column("REPORTED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Reported { get; set; }

    [Column("COLLECTION_OFFSET")]
    public virtual int? CollectionOffset { get; set; }

    [Column("T_PREP_ANALYSIS")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrepAnalysis { get; set; }

    [Column("METHOD")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Method { get; set; }
}