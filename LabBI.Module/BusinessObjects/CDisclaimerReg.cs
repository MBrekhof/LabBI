using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_DISCLAIMER_REG")]
[DefaultClassOptions]
[NavigationItem("Disclaimers")]
[DefaultProperty("ObjectType")]
public partial class CDisclaimerReg : BaseObjectNoID
{
    [Key]
    [Column("SEQ_NUM")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int SeqNum { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string cObjectType { get; set; }

    [Column("OBJECT_ID")]
    public virtual int? ObjectId { get; set; }

    [Column("DISCLAIMER")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? DisclaimerNr { get; set; }
    //[VisibleInListView(true), VisibleInLookupListView(true)]
    //public virtual CDisclaimers Disclaimer { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

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

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }
}