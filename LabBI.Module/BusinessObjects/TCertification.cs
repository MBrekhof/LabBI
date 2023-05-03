
using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("T_CERTIFICATION")]
public  partial class TCertification: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("LOGO")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Logo { get; set; }
}