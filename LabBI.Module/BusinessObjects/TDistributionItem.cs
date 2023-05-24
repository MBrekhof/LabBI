using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("ItemId", "TDistributionList", "Person")]
[Table("T_DISTRIBUTION_ITEM")]
[DefaultClassOptions]
[NavigationItem("T_*")]
[DefaultProperty("TDistributionList")]
public  partial class TDistributionItem: BaseObjectNoID
{
    [Key]
    [Column("ITEM_ID")]
    public virtual int ItemId { get; set; }

    [Key]
    [Column("T_DISTRIBUTION_LIST")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TDistributionList { get; set; }

    [Key]
    [Column("PERSON")]
    public virtual int Person { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("PERSON_NAME")]
    [StringLength(60)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PersonName { get; set; }

    [Column("REPORT_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportPrimary { get; set; }

    [Column("REPORT_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportDelivery { get; set; }

    [Column("INVOICE_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InvoicePrimary { get; set; }

    [Column("INVOICE_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InvoiceDelivery { get; set; }

    [Column("RECEIPT_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReceiptPrimary { get; set; }

    [Column("RECEIPT_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReceiptDelivery { get; set; }
}