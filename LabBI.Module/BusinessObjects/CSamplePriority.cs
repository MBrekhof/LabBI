using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_SAMPLE_PRIORITY")]
public partial class CSamplePriority
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("code")]
    public virtual int Code { get; set; }

    [Column("description")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }
}