using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("COLLECTION_RUN")]
[DefaultClassOptions]
[NavigationItem("Catalogue")]
[DefaultProperty("NAME")]
public  partial class CollectionRun : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("T_DURATION")]
    public virtual int? TDuration { get; set; }

    [Column("T_HOLIDAY_SCHEDULE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string THolidaySchedule { get; set; }

    [Column("T_NOTES")]
    public virtual int? TNotes { get; set; }

    [Column("T_ON_HOLIDAYS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TOnHolidays { get; set; }

    [Column("C_SAMPLER_ID")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CSamplerId { get; set; }
}