using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_SPEC_CODE")]
public partial class CSpecCode
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(256)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("NOTIFICATION")]
    [StringLength(256)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Notification { get; set; }
}