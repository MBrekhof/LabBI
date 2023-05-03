using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;



[Table("CONTAINER_TYPE")]
[DefaultClassOptions]
[NavigationItem("Analysis")]
[DefaultProperty("NAME")]
public  partial class ContainerType : BaseObjectNoID
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
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("CONTAINER_GROUP")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ContainerGroup { get; set; }

    [Column("VOLUME")]
    public virtual int? Volume { get; set; }

    [Column("VOLUME_UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string VolumeUnits { get; set; }

    [Column("UNIQUE_SAMPLES")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UniqueSamples { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("T_CLASS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TClass { get; set; }

    [Column("T_DISPATCH_NAME")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TDispatchName { get; set; }

    [Column("T_DISPATCH_VESSEL")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TDispatchVessel { get; set; }

    [Column("T_LABEL_PRINT_COUNT")]
    public virtual int? TLabelPrintCount { get; set; }

    [Column("T_PREFIX_ID")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrefixId { get; set; }

    [Column("T_REQUEST_QUANTITY")]
    public virtual int? TRequestQuantity { get; set; }

    [Column("T_REQUEST_SEQ_NO")]
    public virtual int? TRequestSeqNo { get; set; }
}