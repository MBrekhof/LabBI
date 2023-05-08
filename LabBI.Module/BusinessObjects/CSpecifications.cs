using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_SPECIFICATIONS")]
public partial class CSpecifications
{
    [Required]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Required]
    [Column("COMPONENT")]
    [StringLength(60)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Component { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Type { get; set; }

    [Required]
    [Column("TYPE_VALUE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TypeValue { get; set; }

    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("SPEC_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecType { get; set; }

    [Column("SPEC_RULE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecRule { get; set; }

    [Column("MINIMUM")]
    public double? Minimum { get; set; }

    [Column("MAXIMUM")]
    public double? Maximum { get; set; }

    [Column("TEXT_VALUE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TextValue { get; set; }

    [Column("UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Units { get; set; }

    [Column("AND_OR")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AndOr { get; set; }

    [Column("MAX_DEVIATION")]
    public virtual int? MaxDeviation { get; set; }

    [Column("REFERENCE_RES_COUNT")]
    public virtual int? ReferenceResCount { get; set; }

    [Required]
    [Column("SPEC_CODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecCode { get; set; }

    [Column("PRIORITY")]
    public virtual int? Priority { get; set; }

    [Column("ACTIVE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Active { get; set; }

    [Column("EMAIL_RES_ENTERED")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EmailResEntered { get; set; }

    [Column("EMAIL_RES_APPROVED")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EmailResApproved { get; set; }

    [Column("EMAIL_TEST_APPROVED")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EmailTestApproved { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }
}