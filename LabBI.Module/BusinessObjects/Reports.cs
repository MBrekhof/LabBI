using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("REPORTS")]
[DefaultClassOptions]
[NavigationItem("Labware Reports")]
[DefaultProperty("Name")]
public  partial class Reports: BaseObjectNoID
{
    [Key]
    [Column("REPORT_NUMBER")]
    public virtual int ReportNumber { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("REPORT_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportType { get; set; }

    [Column("PURPOSE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Purpose { get; set; }

    [Column("OBJECT_CLASS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectClass { get; set; }

    [Column("DATE_CREATED", TypeName = "datetime")]
    public virtual DateTime? DateCreated { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CreatedBy { get; set; }

    [Column("PRINT_COUNT")]
    public virtual int? PrintCount { get; set; }

    [Column("DATA_CHANGED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DataChanged { get; set; }

    [Column("RESULTS_CHANGED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ResultsChanged { get; set; }

    [Column("REPORT_FILE_NAME")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportFileName { get; set; }

    [Column("SUPERSEDED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Superseded { get; set; }

    [Column("SUPERSEDED_BY")]
    public virtual int? SupersededBy { get; set; }

    [Column("ALLOW_EDIT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowEdit { get; set; }

    [Column("ALLOW_PRINT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowPrint { get; set; }

    [Column("REPORT_STATUS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportStatus { get; set; }

    [Column("FAILURE_REASON")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FailureReason { get; set; }

    [Column("ALLOW_WEB_VIEW")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowWebView { get; set; }

    [Column("C_REASON_RECREATED")]
    [StringLength(254)]
    public virtual string CReasonRecreated { get; set; }
}