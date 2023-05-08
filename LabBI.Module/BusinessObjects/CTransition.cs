using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_TRANSITION")]
public partial class CTransition
{
    [Key]
    [Column("TRANS_NR")]
    public virtual int TransNr { get; set; }

    [Column("SAMPLE_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleType { get; set; }

    [Column("COMP_NAME")]
    [StringLength(60)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CompName { get; set; }

    [Column("ANALYSIS")]
    [StringLength(20)]
    public virtual string Analysis { get; set; }

    [Column("SPEC_CODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecCode { get; set; }

    [Column("TRANS_COMP_NAM")]
    [StringLength(60)]
    public virtual string TransCompNam { get; set; }

    [Column("TRANS_ANALYSIS")]
    [StringLength(20)]
    public virtual string TransAnalysis { get; set; }

    [Column("NUM_REPLICATES")]
    public virtual int? NumReplicates { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CreatedBy { get; set; }

    [Column("CREATED_ON", TypeName = "datetime")]
    public virtual DateTime? CreatedOn { get; set; }

    [Column("CHANCHED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChanchedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }
}