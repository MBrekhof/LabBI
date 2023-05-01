using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("UserName", "Analysis")]
[Table("ANALYSIS_APPROVAL")]
[DefaultClassOptions]
[NavigationItem("Samples")]
[DefaultProperty("Analysis")]
public  partial class AnalysisApproval :BaseObjectNoID
{
    [Key]
    [Column("USER_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string UserName { get; set; }

    [Key]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Analysis { get; set; }

    [Column("APPROVAL_DATE", TypeName = "datetime")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual DateTime? ApprovalDate { get; set; }

    [Column("APPROVAL_INTV")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? ApprovalIntv { get; set; }

    [Column("APPROVER")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Approver { get; set; }

    [Column("EXPIRATION_DATE", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? ExpirationDate { get; set; }

    [Column("EXPIRED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Expired { get; set; }
}