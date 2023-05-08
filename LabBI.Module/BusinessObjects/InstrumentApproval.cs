using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("UserName", "Instrument")]
[Table("INSTRUMENT_APPROVAL")]
//[Index("UserName", Name = "INSTRUMENT_AP13995")]
//[Index("Instrument", Name = "INSTRUMENT_APP1413")]
[DefaultClassOptions]
[NavigationItem("Instruments")]
[DefaultProperty("INSTRUMENT")]
public partial class InstrumentApproval
{
    [Key]
    [Column("USER_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UserName { get; set; }

    [Key]
    [Column("INSTRUMENT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Instrument { get; set; }

    [Column("APPROVAL_DATE", TypeName = "datetime")]
    public virtual DateTime? ApprovalDate { get; set; }

    [Column("APPROVAL_INTV")]
    public virtual int? ApprovalIntv { get; set; }

    [Column("APPROVER")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Approver { get; set; }

    [Column("EXPIRATION_DATE", TypeName = "datetime")]
    public virtual DateTime? ExpirationDate { get; set; }

    [Column("EXPIRED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Expired { get; set; }
}