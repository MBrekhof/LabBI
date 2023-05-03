using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("SAMPLE_RULES")]
public  partial class SampleRules: BaseObjectNoID
{
    [Key]
    [Column("ENTRY_CODE")]
    public virtual int EntryCode { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("ANALYSIS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Column("VARIATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Variation { get; set; }

    [Column("SAMPLE_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleType { get; set; }

    [Column("CONTAINER_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ContainerType { get; set; }

    [Column("COLLECTION_METHOD")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CollectionMethod { get; set; }

    [Column("STORAGE_CONDITION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StorageCondition { get; set; }

    [Column("TEST_LIST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestList { get; set; }

    [Column("CONTRACT_NUMBER")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ContractNumber { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Customer { get; set; }

    [Column("PRODUCT")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Product { get; set; }

    [Column("T_CONTRACT_TESTS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TContractTests { get; set; }

    [Column("JUISTE_FLES")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string JuisteFles { get; set; }
}