using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_OOS_DISTR_LIST")]
//[Index("Name", Name = "idx_COOSDISTRLIST_NAME", IsUnique = true)]
public partial class COosDistrList
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("DEFAULT_SUBJECT")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DefaultSubject { get; set; }

    [Column("DEFAULT_TEXT")]
    [StringLength(500)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DefaultText { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public virtual DateTime? DateCreated { get; set; }
}