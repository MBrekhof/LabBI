using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LabBI.Module.BusinessObjects;

[Table("COMMON_NAME")]

[DefaultClassOptions]
[NavigationItem("Catalogue")]
[DefaultProperty("NAME")]
public  partial class CommonName: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Removed { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }
}