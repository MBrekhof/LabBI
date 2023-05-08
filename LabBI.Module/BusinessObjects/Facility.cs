using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("FACILITY")]
public partial class Facility
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

    [Column("PARENT_FACILITY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParentFacility { get; set; }

    [Column("ADDRESS1")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address1 { get; set; }

    [Column("ADDRESS2")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address2 { get; set; }

    [Column("ADDRESS3")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address3 { get; set; }

    [Column("ADDRESS4")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address4 { get; set; }

    [Column("ADDRESS5")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address5 { get; set; }

    [Column("ADDRESS6")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address6 { get; set; }

    [Column("FACILITY_TYPE")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FacilityType { get; set; }

    [Column("LAB_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string LabGroup { get; set; }

    [Column("T_OUTSIDE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TOutside { get; set; }

    [Column("T_ALL_COMP_ACCRED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAllCompAccred { get; set; }

    [Column("T_CERTIFICATION")]
    [StringLength(30)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCertification { get; set; }

    [Column("T_SHIP_REQUEST_EMAIL")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TShipRequestEmail { get; set; }

    [Column("T_PHONE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPhone { get; set; }
}