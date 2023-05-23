using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Invoices")]
    [DefaultProperty("InvoiceNumber")]
    public   class Invoice : BaseObjectNoID
    {
        [Key]
        [Column("INVOICE_NUMBER")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual int InvoiceNumber { get; set; }

        [Column("CONTRACT_NUMBER")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual int? ContractNumber { get; set; }

        [Column("CUSTOMER")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false),VisibleInDetailView(false)]
        public virtual string Customername { get; set; }
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual Customer Customer { get; set; }

        [Column("INVOICE_ID")]
        [MaxLength(20)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string InvoiceId { get; set; }

        [Column("PO_NUMBER")]
        [MaxLength(20)]
        [VisibleInListView(false),VisibleInLookupListView(false)]
        public virtual string PoNumber { get; set; }

        [Column("CHANGED_BY")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ChangedBy { get; set; }

        [Column("CHANGED_ON", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? ChangedOn { get; set; }

        [Column("GROUP_NAME")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string GroupName { get; set; }

        [Column("CLOSED")]
        [MaxLength(1),FieldSize(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Closed { get; set; }

        [Column("INVOICE_STARTED", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
      
        public virtual DateTime? InvoiceStarted { get; set; }

        [Column("INVOICE_SCHED_DATE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? InvoiceSchedDate { get; set; }

        [Column("INVOICED_ON", TypeName = "datetime")]
       // [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? InvoicedOn { get; set; }

        [Column("INVOICED_BY")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        [MaxLength(20)]
        public virtual string InvoicedBy { get; set; }

        [Column("EXCHANGE_FACTOR")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual float? ExchangeFactor { get; set; }

        [Column("ITEM_TOTAL")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual float? ItemTotal { get; set; }

        [Column("ADJUSTMENT_TOTAL")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual float? AdjustmentTotal { get; set; }

        [Column("AMOUNT_DUE")]
        [VisibleInListView(true), VisibleInLookupListView(false)]
        public virtual float? AmountDue { get; set; }

        [Column("PAYMENT_DUE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? PaymentDue { get; set; }

        [Column("INVOICE_COMMENTS")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InvoiceComments { get; set; }

        [Column("INTERNAL_COMMENTS")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InternalComments { get; set; }

        [Column("PRINT_COUNT")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? PrintCount { get; set; }

        [Column("PRINTED_BY")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string PrintedBy { get; set; }

        [Column("PRINTED_ON", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? PrintedOn { get; set; }

        [Column("LAST_PRINT_FILE")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LastPrintFile { get; set; }

        [Column("T_CUMULATIVE_ID")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCumulativeId { get; set; }

        [Column("T_CUSTOMER_GROUP")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCustomerGroup { get; set; }

        [Column("T_CUSTOMER_PO")]
        [MaxLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCustomerPo { get; set; }

        [Column("T_FIN_SYS_EXPORT_ON", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TFinSysExportOn { get; set; }

        [Column("T_INVOICE_MONTH")]
        [MaxLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TInvoiceMonth { get; set; }

        [Column("T_INVOICE_YEAR")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TInvoiceYear { get; set; }

        [Column("T_PDF_FILE")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPdfFile { get; set; }

        [Column("T_REVIEW_REQ")]
        [MaxLength(1)]
     
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public virtual string TReviewReq { get; set; }


        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new ObservableCollection<InvoiceItem>();
    }
}



