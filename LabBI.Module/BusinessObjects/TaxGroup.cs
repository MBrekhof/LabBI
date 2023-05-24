using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("TAX_GROUP")]
[DefaultClassOptions]
[NavigationItem("Invoices")]
[DefaultProperty("Name")]
public  partial class TaxGroup: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("TAX_RATE")]
    [StringLength(50)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string TaxRate { get; set; }

    [Column("FIXED_TAX")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FixedTax { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }
}