using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LabBI.Module.BusinessObjects.BusinessObjects;

[PrimaryKey("Name", "Version")]
[Table("CATALOGUE")]
//[Index("Name", Name = "CATALOGUE_NAM15097")]
[DefaultClassOptions]
[NavigationItem("Samples")]
[DefaultProperty("Name")]

public partial class Catalogue : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(true), VisibleInLookupListView(true)]

    public virtual string Name { get; set; }

    [Key]
    [Column("VERSION")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int Version { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [Unicode(false)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(25)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("EFFECTIVE_DATE", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? EffectiveDate { get; set; }

    [Column("APPROVED")]
    [StringLength(1)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Approved { get; set; }

    [Column("APPROVAL_GROUP")]
    [StringLength(10)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ApprovalGroup { get; set; }

    [Column("READY_FOR_APPROVAL")]
    [StringLength(1)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReadyForApproval { get; set; }

    [Column("APPROVAL_ID")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? ApprovalId { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ActiveFlag { get; set; }

    [Column("CATALOGUE_CURRENCY")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CatalogueCurrency { get; set; }

    [Column("SEARCH_TEMPLATE")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SearchTemplate { get; set; }

    [Column("DEFAULT_TAX_GROUP")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DefaultTaxGroup { get; set; }

    [Column("QUANT_PRICE_IS_DISC")]
    [StringLength(1)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuantPriceIsDisc { get; set; }

    [Column("REPORT_FORMAT")]
    [StringLength(20)]
    [Unicode(false)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportFormat { get; set; }

    [Column("COST_ITEM_DISCOUNT")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? CostItemDiscount { get; set; }
}