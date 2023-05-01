using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("CRM")]
    [DefaultProperty("AccountNumber")]
    public class Account : BaseObjectNoID
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ACCOUNT_NUMBER")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual int AccountNumber { get; set; }

        [MaxLength(20)]
        [Column("CUSTOMER", TypeName = "varchar(20)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string Customer { get; set; }

        [MaxLength(20)]
        [Column("CHANGED_BY", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ChangedBy { get; set; }

        [Column("CHANGED_ON", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? ChangedOn { get; set; }

        [MaxLength(1)]
        [Column("REMOVED", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Removed { get; set; }

        [MaxLength(254)]
        [Column("DESCRIPTION", TypeName = "varchar(254)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Description { get; set; }

        [MaxLength(1)]
        [Column("ON_HOLD", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string OnHold { get; set; }

        [MaxLength(20)]
        [Column("INVOICE_TO", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InvoiceTo { get; set; }

        [MaxLength(20)]
        [Column("COPY_1_TO", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Copy1To { get; set; }

        [MaxLength(20)]
        [Column("COPY_2_TO", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Copy2To { get; set; }

        [MaxLength(20)]
        [Column("GROUP_NAME", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string GroupName { get; set; }

        [MaxLength(20)]
        [Column("TAX_PLAN", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TaxPlan { get; set; }

        [MaxLength(254)]
        [Column("EXT_LINK", TypeName = "varchar(254)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string ExtLink { get; set; }
    }
}
