using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_SAMPLED_BY")]
public partial class CSampledBy
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("CODE")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Code { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CreatedBy { get; set; }

    [Column("CREATED_ON", TypeName = "datetime")]
    public virtual DateTime? CreatedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Required]
    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }
}