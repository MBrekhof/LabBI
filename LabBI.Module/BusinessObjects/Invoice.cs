using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBI.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Invoices")]
    public class Invoice : BaseObjectNoID
    {
        [Key]
        public virtual int InvoiceNumber { get; set; }
        public virtual int? ContractNumber { get; set; }
        public virtual string Customer { get; set; }
        public virtual string InvoiceId { get; set; }
        public virtual string PoNumber { get; set; }
        public virtual string ChangedBy { get; set; }
        public virtual DateTime? ChangedOn { get; set; }
        public virtual string GroupName { get; set; }
        public virtual string Closed { get; set; }
        public virtual DateTime? InvoiceStarted { get; set; }
        public virtual DateTime? InvoiceSchedDate { get; set; }
        public virtual DateTime? InvoicedOn { get; set; }
        public virtual string InvoicedBy { get; set; }

        public virtual float? ExchangeFactor { get; set; }
        public virtual float? ItemTotal { get; set; }
        public virtual float? AdjustmentTotal { get; set; }
        public virtual float? AmountDue { get; set; }
        public virtual DateTime? PaymentDue { get; set; }
        public virtual string InvoiceComments { get; set; }
        public virtual string InternalComments { get; set; }
        public virtual int? PrintCount { get; set; }
        public virtual string PrintedBy { get; set; }
        public virtual DateTime? PrintedOn { get; set; }
        public virtual string LastPrintFile { get; set; }
        public virtual string TCumulativeId { get; set; }
        public virtual string TCustomerGroup { get; set; }
        public virtual string TCustomerPO { get; set; }
        public virtual DateTime? TFinSysExportOn { get; set; }
        public virtual string TInvoiceMonth { get; set; }
        public virtual int? TInvoiceYear { get; set; }
        public virtual string TPdfFile { get; set; }
        public virtual string TReviewReq { get; set; }
    }


}

