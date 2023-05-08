using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_ACCREDITATION")]
public partial class CAccreditation
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Required]
    [Column("COMPONENT")]
    [StringLength(60)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Component { get; set; }

    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int OrderNumber { get; set; }

    [Required]
    [Column("MATRIX")]
    [StringLength(2)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Matrix { get; set; }

    [Column("ACCREDITATION")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Accreditation { get; set; }

    [Column("Q_CODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }
}