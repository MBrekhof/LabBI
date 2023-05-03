using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("COST_ITEM")]
[DefaultClassOptions]
[NavigationItem("Catalogue")]
[DefaultProperty("ITEM_CODE")]
public partial class CostItem : BaseObjectNoID
{
    [Key]
    [Column("COST_ITEM_NO")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int CostItemNo { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(30)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ItemCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }

    [Column("BASE_CURRENCY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BaseCurrency { get; set; }

    [Column("BASE_COST")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BaseCost { get; set; }

    [Column("PERCENT_MARGIN")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PercentMargin { get; set; }

    [Column("LIST_PRICE")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ListPrice { get; set; }

    [Column("OBJECT_TABLE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectTable { get; set; }

    [Column("OBJECT_KEY")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectKey { get; set; }

    [Column("OBJECT_TABLE_2")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectTable2 { get; set; }

    [Column("OBJECT_KEY_2")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectKey2 { get; set; }

    [Column("EXT_LINK")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ActiveFlag { get; set; }

    [Column("DISCOUNTABLE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Discountable { get; set; }

    [Column("T_ANALYSIS_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAnalysisType { get; set; }

    [Column("T_COMMON_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCommonName { get; set; }

    [Column("NUM_RESULTS")]
    public virtual int? NumResults { get; set; }

    [Column("XTRA_RSLT_COST_ITM")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string XtraRsltCostItm { get; set; }

    [Column("BASE_ITEM")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BaseItem { get; set; }

    [Column("ALL_RSLTS_SAME_PRICE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllRsltsSamePrice { get; set; }

    [Column("ASSOCIATED_COST_ITEM")]
    public virtual int? AssociatedCostItem { get; set; }
}