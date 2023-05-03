using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("TEST_LIST")]
public  partial class TestList: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GLOBAL_FLAG")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GlobalFlag { get; set; }

    [Column("OWNER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Owner { get; set; }

    [Column("SET_RSLT_ORDER_NO")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SetRsltOrderNo { get; set; }

    [Column("APPROVAL_ROLE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ApprovalRole { get; set; }

    [Column("T_ALLOWED_PRODUCT")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAllowedProduct { get; set; }

    [Column("T_ALLOWED_SAM_TYPE")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAllowedSamType { get; set; }

    [Column("T_PREREQ_CLEAR_STATUS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrereqClearStatus { get; set; }

    [Column("C_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CType { get; set; }

    [Column("C_PACKAGE")]
    [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CPackage { get; set; }
}