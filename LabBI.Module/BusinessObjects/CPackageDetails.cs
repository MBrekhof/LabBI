using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_PACKAGE_DETAILS")]
//[Index("CPackage", "TestList", Name = "idx_CPACKAGEDETAILS_PACK", IsUnique = true)]
public partial class CPackageDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("C_PACKAGE")]
    [StringLength(4)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CPackage { get; set; }

    [Required]
    [Column("TEST_LIST")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestList { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }
}