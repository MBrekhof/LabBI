using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("CONTRACT_QUOTE")]
//[Index("Customer", Name = "idxContractQuoteCustomer")]
[DefaultClassOptions]
[NavigationItem("Catalogue")]
[DefaultProperty("CONTRACT_QUOTE_ID")]
public  partial class ContractQuote : BaseObjectNoID
{
    [Key]
    [Column("CONTRACT_QUOTE_NO")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int ContractQuoteNo { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CONTRACT_QUOTE_ID")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ContractQuoteId { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("ACCOUNT_NUMBER")]
    public virtual int? AccountNumber { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Customer { get; set; }

    [Column("MASTER_CONTRACT")]
    public virtual int? MasterContract { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }

    [Column("PAYMENT_DUE_DAYS")]
    public virtual int? PaymentDueDays { get; set; }

    [Column("TAX_PLAN")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxPlan { get; set; }

    [Column("BASE_CURRENCY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BaseCurrency { get; set; }

    [Column("QUOTE_CURRENCY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuoteCurrency { get; set; }

    [Column("QUOTE_EXCHANGE")]
    public virtual float? QuoteExchange { get; set; }

    [Column("BILLING_CURRENCY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BillingCurrency { get; set; }

    [Column("INVOICE_TEST_LISTS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InvoiceTestLists { get; set; }

    [Column("ALL_QUANTITY_PRICE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllQuantityPrice { get; set; }

    [Column("QUANT_BY_INVOICE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuantByInvoice { get; set; }

    [Column("DISCOUNT_PERCENT")]
    public virtual int? DiscountPercent { get; set; }

    [Column("SURCHARGE_PERCENT")]
    public virtual int? SurchargePercent { get; set; }

    [Column("ROUND_TO")]
    public virtual float? RoundTo { get; set; }

    [Column("QUOTE_EXPIRATION", TypeName = "datetime")]
    public virtual DateTime? QuoteExpiration { get; set; }

    [Column("CONTRACT_EFFECTIVE", TypeName = "datetime")]
    public virtual DateTime? ContractEffective { get; set; }

    [Column("CONTRACT_EXPIRES", TypeName = "datetime")]
    public virtual DateTime? ContractExpires { get; set; }

    [Column("CONTRACTED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Contracted { get; set; }

    [Column("CONTRACT_ITMS_ONLY")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ContractItmsOnly { get; set; }

    [Column("CURRENT_PO_NUMBER")]
    [StringLength(40)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CurrentPoNumber { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ActiveFlag { get; set; }

    [Column("INVOICE_INTERVAL")]
    public virtual int? InvoiceInterval { get; set; }

    [Column("INTERVAL_UNITS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string IntervalUnits { get; set; }

    [Column("FIRST_INVOICE", TypeName = "datetime")]
    public virtual DateTime? FirstInvoice { get; set; }

    [Column("SPECIAL_INSTRUCT")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecialInstruct { get; set; }

    [Column("DISPLAY_MESSAGE")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DisplayMessage { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("QUOTE_ID_CONFIG")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuoteIdConfig { get; set; }

    [Column("INVOICE_ID_CONFIG")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InvoiceIdConfig { get; set; }

    [Column("EXT_LINK")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("QUOTATION_FORMAT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuotationFormat { get; set; }

    [Column("REPORT_FILE_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportFileType { get; set; }

    [Column("INVOICE_FORMAT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InvoiceFormat { get; set; }

    [Column("PRINT_COUNT")]
    public virtual int? PrintCount { get; set; }

    [Column("PRINTED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PrintedBy { get; set; }

    [Column("PRINTED_ON", TypeName = "datetime")]
    public virtual DateTime? PrintedOn { get; set; }

    [Column("LAST_PRINT_FILE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string LastPrintFile { get; set; }

    [Column("PRE_INV_ID_CONFIG")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PreInvIdConfig { get; set; }

    [Column("MASTER_CNTRCT_DISC")]
    public virtual int? MasterCntrctDisc { get; set; }

    [Column("MASTER_CNTRCT_SUR")]
    public virtual int? MasterCntrctSur { get; set; }

    [Column("T_CLIENT_ID")]
    public virtual int? TClientId { get; set; }

    [Column("T_CLIENT_NAME")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TClientName { get; set; }

    [Column("T_CONTRACT_TESTS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TContractTests { get; set; }

    [Column("T_DATE_CREATED", TypeName = "datetime")]
    public virtual DateTime? TDateCreated { get; set; }

    [Column("T_INVOICE_DIST")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoiceDist { get; set; }

    [Column("T_INVOICE_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoiceGroup { get; set; }

    [Column("T_INVOICE_PRIMARY")]
    public virtual int? TInvoicePrimary { get; set; }

    [Column("T_ITEM_DISCOUNT")]
    public virtual int? TItemDiscount { get; set; }

    [Column("T_ITEM_TOTAL")]
    public virtual float? TItemTotal { get; set; }

    [Column("T_NOTE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TNote { get; set; }

    [Column("T_REPORT_DIST")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReportDist { get; set; }

    [Column("T_REPORT_PRIMARY")]
    public virtual int? TReportPrimary { get; set; }

    [Column("T_REVISION_NOTE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TRevisionNote { get; set; }

    [Column("T_REVISION_NUMBER")]
    public virtual int? TRevisionNumber { get; set; }

    [Column("T_SURCHARGE_SCHEME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TSurchargeScheme { get; set; }

    [Column("PRE_INVOICE_FORMAT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PreInvoiceFormat { get; set; }

    [Column("T_QUOTE_BODY")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TQuoteBody { get; set; }

    [Column("CATALOGUE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Catalogue { get; set; }

    [Column("CATALOGUE_VERSION")]
    public virtual int? CatalogueVersion { get; set; }

    [Column("USE_LATEST_CAT_VER")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UseLatestCatVer { get; set; }

    [Column("SEARCH_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SearchTemplate { get; set; }

    [Column("QUANT_PRICE_IS_DISC")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string QuantPriceIsDisc { get; set; }

    [Column("CAT_ITEM_DISC")]
    public virtual int? CatItemDisc { get; set; }

    [Column("CAT_ITEM_SUR")]
    public virtual int? CatItemSur { get; set; }

    [Column("T_RECEIPT_DIST")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReceiptDist { get; set; }

    [Column("T_RECEIPT_PRIMARY")]
    public virtual int? TReceiptPrimary { get; set; }

    [Column("T_PROGRAM")]
    [StringLength(30)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TProgram { get; set; }

    [Column("C_MAX_INVOICE_AMOUNT")]
    public virtual double? CMaxInvoiceAmount { get; set; }

    [Column("C_LANGUAGE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CLanguage { get; set; }

    [Column("C_REPORT_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CReportGroup { get; set; }
}