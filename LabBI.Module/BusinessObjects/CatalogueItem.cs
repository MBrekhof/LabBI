using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("CATALOGUE_ITEM")]
//[Index("Catalogue", "Version", Name = "idxCATALOGUE_ITEM_CATVER")]
[DefaultClassOptions]
[NavigationItem("Catalogue")]
[DefaultProperty("ITEM_CODE")]
public  partial class CatalogueItem : BaseObjectNoID
{
    [Required]
    [Column("CATALOGUE")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Catalogue { get; set; }

    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("COST_ITEM_NO")]
    public virtual int CostItemNo { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(30)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ItemCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("LIST_PRICE")]
    [StringLength(10)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ListPrice { get; set; }

    [Column("QUANTITY_1")]
    public virtual int? Quantity1 { get; set; }

    [Column("QUANTITY_1_PRICE")]
    public virtual float? Quantity1Price { get; set; }

    [Column("QUANTITY_2")]
    public virtual int? Quantity2 { get; set; }

    [Column("QUANTITY_2_PRICE")]
    public virtual float? Quantity2Price { get; set; }

    [Column("QUANTITY_3")]
    public virtual int? Quantity3 { get; set; }

    [Column("QUANTITY_3_PRICE")]
    public virtual float? Quantity3Price { get; set; }

    [Column("CUMULATIVE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Cumulative { get; set; }

    [Key]
    [Column("CATALOGUE_ITEM_NO")]
    public virtual int CatalogueItemNo { get; set; }

    [Column("TAX_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxGroup { get; set; }

    [Column("DISCOUNTABLE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Discountable { get; set; }
}