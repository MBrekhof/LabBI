using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_OOS_DISTR_ITEM")]
public partial class COosDistrItem
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("C_DISTRIBUTION_LIST")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CDistributionList { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Type { get; set; }

    [Required]
    [Column("EMAIL")]
    [StringLength(30)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Email { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("DATE_FROM", TypeName = "date")]
    public DateTime DateFrom { get; set; }

    [Column("DATE_TO", TypeName = "date")]
    public virtual DateTime? DateTo { get; set; }

    [Column("CUSTOMER_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CustomerSelection { get; set; }

    [Column("SAMPLINGPOINT_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SamplingpointSelection { get; set; }

    [Column("SAMPLETYPE_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampletypeSelection { get; set; }

    [Column("MATRIX_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MatrixSelection { get; set; }

    [Column("ANALYSIS_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AnalysisSelection { get; set; }

    [Column("ANALYSISTYPE_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AnalysistypeSelection { get; set; }

    [Column("MONTH_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MonthSelection { get; set; }

    [Column("WEEK_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string WeekSelection { get; set; }

    [Column("MONTHDAY_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MonthdaySelection { get; set; }

    [Column("WEEKDAY_SELECTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string WeekdaySelection { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public DateTime DateCreated { get; set; }

    [Required]
    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime ChangedOn { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int OrderNumber { get; set; }
}