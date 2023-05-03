using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("SAMPLING_POINT")]
//[Index("CCustomer", Name = "idxSamplingPointCustomer")]
public  partial class SamplingPoint : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("TEST_LIST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestList { get; set; }

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

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("PRIMARY_DISP_REQ")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PrimaryDispReq { get; set; }

    [Column("SECONDARY_DISP_REQ")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SecondaryDispReq { get; set; }

    [Column("T_LAB")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLab { get; set; }

    [Column("T_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLocation { get; set; }

    [Column("PRIMARY_RUN")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PrimaryRun { get; set; }

    [Column("SECONDARY_RUN")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SecondaryRun { get; set; }

    [Column("TERTIARY_RUN")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TertiaryRun { get; set; }

    [Column("SAMPLER_ID")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SamplerId { get; set; }

    [Column("SERVICE_RESERVOIR")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ServiceReservoir { get; set; }

    [Column("TREATMENT_WORKS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TreatmentWorks { get; set; }

    [Column("ZONE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Zone { get; set; }

    [Column("WATER_SOURCE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string WaterSource { get; set; }

    [Column("SAMPLE_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleTemplate { get; set; }

    [Column("T_COLLECTION_NOTES")]
    public virtual int? TCollectionNotes { get; set; }

    [Column("T_MAP_ZOOM")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TMapZoom { get; set; }

    [Column("T_PHOTO")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPhoto { get; set; }

    [Column("T_UTM_LATITUDE")]
    public virtual float? TUtmLatitude { get; set; }

    [Column("T_UTM_LONGITUDE")]
    public virtual float? TUtmLongitude { get; set; }

    [Column("C_CUSTOMER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CCustomer { get; set; }

    [Column("C_SAMPLE_TYPE")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CSampleType { get; set; }

    [Column("T_LATLONG")]
    [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLatlong { get; set; }
}