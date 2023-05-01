using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
using LabBI.Module.BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Invoices")]
    [Table("INVOICE_ITEM")]
    public class InvoiceItem : BaseObjectNoID
    {
        [Column("INVOICE_NUMBER")]
        public virtual int? InvoiceId { get; set; }
        public virtual Invoice InvoiceNumber { get; set; }

        [Key]
        [Column("INVOICE_ITEM_NO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int InvoiceItemNo { get; set; }

        [Column("CONTRACT_ITEM_NO")]
        public virtual int? ContractItemNo { get; set; }

        [Column("COST_ITEM_NO")]
        public virtual int? CostItemNo { get; set; }

        [Column("QUANTITY")]
        public virtual float? Quantity { get; set; }

        [Column("BILLING_ITEM_DESC")]
        [StringLength(50)]
        public virtual string BillingItemDesc { get; set; }

        [Column("UNIT_PRICE")]
        public virtual float? UnitPrice { get; set; }

        [Column("TOTAL_PRICE")]
        public virtual float? TotalPrice { get; set; }

        [Column("CANCELLED")]
        [StringLength(1)]
        public virtual string Cancelled { get; set; }

        [Column("TAX_GROUP")]
        [StringLength(20)]
        public virtual string TaxGroup { get; set; }

        [Column("OBJECT_TABLE")]
        [StringLength(20)]
        public virtual string ObjectTable { get; set; }

        [Column("OBJECT_KEY")]
        [StringLength(50)]
        public virtual string ObjectKey { get; set; }

        [Column("QUANTITY_LEVEL")]
        public virtual int? QuantityLevel { get; set; }

        [Column("T_SURCHARGE_PCT")]
        public virtual float? TSurchargePct { get; set; }

        [Column("T_SURCHARGED_ITM")]
        public virtual int? TSurchargedItm { get; set; }

        [Column("CATALOGUE_ITEM_NO")]
        public virtual int? CatalogueItemNo { get; set; }

    }

}