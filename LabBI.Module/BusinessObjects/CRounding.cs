using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_ROUNDING")]
//[Index("Matrix", "Analysis", "Component", Name = "idx_Rounding_MaAnCo")]
public partial class CRounding
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("MATRIX")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Matrix { get; set; }

    [Required]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Column("COMPONENT")]
    [StringLength(60)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Component { get; set; }

    [Column("LOWER_LIMIT")]
    public double? LowerLimit { get; set; }

    [Column("UPPER_LIMIT")]
    public double? UpperLimit { get; set; }

    [Column("ROUND_TO")]
    public double? RoundTo { get; set; }

    [Column("MAX_LIMIT")]
    public virtual short MaxLimit { get; set; }

    [Column("ACTIVE")]
    public virtual short Active { get; set; }

    [Column("EFFECTIVE_DATE", TypeName = "date")]
    public DateTime EffectiveDate { get; set; }

    [Required]
    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime ChangedOn { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public DateTime DateCreated { get; set; }
}