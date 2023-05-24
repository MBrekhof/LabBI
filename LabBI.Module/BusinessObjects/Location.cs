using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("LOCATION")]
[DefaultClassOptions]
[NavigationItem("CRM")]
[DefaultProperty("Name")]
public  partial class Location: BaseObjectNoID
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

    [Column("ADDRESS")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address { get; set; }

    [Column("ZIP")]
    [StringLength(9)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Zip { get; set; }

    [Column("CONTACT")]
    [StringLength(78)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Contact { get; set; }

    [Column("PHONE")]
    [StringLength(30)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Phone { get; set; }

    [Column("FAX")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Fax { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("OUTSIDE")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Outside { get; set; }

    [Column("COMPANY")]
    [StringLength(50)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Company { get; set; }

    [Column("SITE")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Site { get; set; }

    [Column("BUILDING")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Building { get; set; }

    [Column("ROOM_NUMBER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string RoomNumber { get; set; }

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

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("FACILITY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Facility { get; set; }

    [Column("LOCATION_TYPE")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string LocationType { get; set; }

    [Column("C_CITY")]
    [StringLength(80)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CCity { get; set; }
}