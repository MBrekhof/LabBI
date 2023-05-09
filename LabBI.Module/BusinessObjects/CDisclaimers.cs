using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_DISCLAIMERS")]
[DefaultClassOptions]
[NavigationItem("Disclaimers")]
[DefaultProperty("Code")]
public partial class CDisclaimers : BaseObjectNoID
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("NIVEAU")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Niveau { get; set; }

    [Column("CATEGORY")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Categoryname { get; set; }
    //[VisibleInListView(true), VisibleInLookupListView(true)]
    //public virtual CDisclaimerCat Category { get; set; }

    [Column("CODE")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Code { get; set; }

    [Column("DISCLAIMER")]
    public virtual string Disclaimer { get; set; }

    [Column("DISCLAIMER_EN")]
    public virtual string DisclaimerEn { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("DESCRIPTION_EN")]
    [StringLength(254)]
    public virtual string DescriptionEn { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

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

    [Column("REPORTABLE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Reportable { get; set; }
}