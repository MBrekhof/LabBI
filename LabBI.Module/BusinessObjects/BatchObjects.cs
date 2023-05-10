using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;


[PrimaryKey("BatchName", "ObjectId", "OrderNumber")]
[Table("BATCH_OBJECTS")]
//[Index("ObjectId", Name = "idx_BATCH_OBJECTS_OBJECTID")]
[DefaultClassOptions]
[NavigationItem("Batch")]
[DefaultProperty("Batch")]
public partial class BatchObjects
{
    [Key]
    [Column("BATCH")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchName { get; set; }

    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual Batch Batch { get; set; }
    [Key]
    [Column("OBJECT_ID")]
    public virtual int ObjectId { get; set; }

    [Key]
    [Column("ORDER_NUMBER")]
    public virtual int OrderNumber { get; set; }

    [Column("SAMPLE_TYPE")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleType { get; set; }

    [Column("REFERENCE_SAMPLE")]
    public virtual int? ReferenceSample { get; set; }

    [Column("PARAMETER_1")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter1 { get; set; }

    [Column("PARAMETER_2")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter2 { get; set; }

    [Column("SAMPLE_NUMBER")]
    public virtual int? SampleNumber { get; set; }
}