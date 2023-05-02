﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[Table("CONTRACT_QUOTE")]
[Index("Customer", Name = "idxContractQuoteCustomer")]
public partial class ContractQuote
{
    [Key]
    [Column("CONTRACT_QUOTE_NO")]
    public int ContractQuoteNo { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("CONTRACT_QUOTE_ID")]
    [StringLength(20)]
    [Unicode(false)]
    public string ContractQuoteId { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("ACCOUNT_NUMBER")]
    public int? AccountNumber { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]
    [Unicode(false)]
    public string Customer { get; set; }

    [Column("MASTER_CONTRACT")]
    public int? MasterContract { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string GroupName { get; set; }

    [Column("PAYMENT_DUE_DAYS")]
    public int? PaymentDueDays { get; set; }

    [Column("TAX_PLAN")]
    [StringLength(20)]
    [Unicode(false)]
    public string TaxPlan { get; set; }

    [Column("BASE_CURRENCY")]
    [StringLength(20)]
    [Unicode(false)]
    public string BaseCurrency { get; set; }

    [Column("QUOTE_CURRENCY")]
    [StringLength(20)]
    [Unicode(false)]
    public string QuoteCurrency { get; set; }

    [Column("QUOTE_EXCHANGE")]
    public float? QuoteExchange { get; set; }

    [Column("BILLING_CURRENCY")]
    [StringLength(20)]
    [Unicode(false)]
    public string BillingCurrency { get; set; }

    [Column("INVOICE_TEST_LISTS")]
    [StringLength(1)]
    [Unicode(false)]
    public string InvoiceTestLists { get; set; }

    [Column("ALL_QUANTITY_PRICE")]
    [StringLength(1)]
    [Unicode(false)]
    public string AllQuantityPrice { get; set; }

    [Column("QUANT_BY_INVOICE")]
    [StringLength(1)]
    [Unicode(false)]
    public string QuantByInvoice { get; set; }

    [Column("DISCOUNT_PERCENT")]
    public int? DiscountPercent { get; set; }

    [Column("SURCHARGE_PERCENT")]
    public int? SurchargePercent { get; set; }

    [Column("ROUND_TO")]
    public float? RoundTo { get; set; }

    [Column("QUOTE_EXPIRATION", TypeName = "datetime")]
    public DateTime? QuoteExpiration { get; set; }

    [Column("CONTRACT_EFFECTIVE", TypeName = "datetime")]
    public DateTime? ContractEffective { get; set; }

    [Column("CONTRACT_EXPIRES", TypeName = "datetime")]
    public DateTime? ContractExpires { get; set; }

    [Column("CONTRACTED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Contracted { get; set; }

    [Column("CONTRACT_ITMS_ONLY")]
    [StringLength(1)]
    [Unicode(false)]
    public string ContractItmsOnly { get; set; }

    [Column("CURRENT_PO_NUMBER")]
    [StringLength(40)]
    [Unicode(false)]
    public string CurrentPoNumber { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    [Unicode(false)]
    public string ActiveFlag { get; set; }

    [Column("INVOICE_INTERVAL")]
    public int? InvoiceInterval { get; set; }

    [Column("INTERVAL_UNITS")]
    [StringLength(20)]
    [Unicode(false)]
    public string IntervalUnits { get; set; }

    [Column("FIRST_INVOICE", TypeName = "datetime")]
    public DateTime? FirstInvoice { get; set; }

    [Column("SPECIAL_INSTRUCT")]
    [StringLength(255)]
    [Unicode(false)]
    public string SpecialInstruct { get; set; }

    [Column("DISPLAY_MESSAGE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DisplayMessage { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Removed { get; set; }

    [Column("QUOTE_ID_CONFIG")]
    [StringLength(20)]
    [Unicode(false)]
    public string QuoteIdConfig { get; set; }

    [Column("INVOICE_ID_CONFIG")]
    [StringLength(20)]
    [Unicode(false)]
    public string InvoiceIdConfig { get; set; }

    [Column("EXT_LINK")]
    [StringLength(255)]
    [Unicode(false)]
    public string ExtLink { get; set; }

    [Column("QUOTATION_FORMAT")]
    [StringLength(20)]
    [Unicode(false)]
    public string QuotationFormat { get; set; }

    [Column("REPORT_FILE_TYPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string ReportFileType { get; set; }

    [Column("INVOICE_FORMAT")]
    [StringLength(20)]
    [Unicode(false)]
    public string InvoiceFormat { get; set; }

    [Column("PRINT_COUNT")]
    public int? PrintCount { get; set; }

    [Column("PRINTED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string PrintedBy { get; set; }

    [Column("PRINTED_ON", TypeName = "datetime")]
    public DateTime? PrintedOn { get; set; }

    [Column("LAST_PRINT_FILE")]
    [StringLength(20)]
    [Unicode(false)]
    public string LastPrintFile { get; set; }

    [Column("PRE_INV_ID_CONFIG")]
    [StringLength(20)]
    [Unicode(false)]
    public string PreInvIdConfig { get; set; }

    [Column("MASTER_CNTRCT_DISC")]
    public int? MasterCntrctDisc { get; set; }

    [Column("MASTER_CNTRCT_SUR")]
    public int? MasterCntrctSur { get; set; }

    [Column("T_CLIENT_ID")]
    public int? TClientId { get; set; }

    [Column("T_CLIENT_NAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string TClientName { get; set; }

    [Column("T_CONTRACT_TESTS")]
    [StringLength(1)]
    [Unicode(false)]
    public string TContractTests { get; set; }

    [Column("T_DATE_CREATED", TypeName = "datetime")]
    public DateTime? TDateCreated { get; set; }

    [Column("T_INVOICE_DIST")]
    [StringLength(255)]
    [Unicode(false)]
    public string TInvoiceDist { get; set; }

    [Column("T_INVOICE_GROUP")]
    [StringLength(20)]
    [Unicode(false)]
    public string TInvoiceGroup { get; set; }

    [Column("T_INVOICE_PRIMARY")]
    public int? TInvoicePrimary { get; set; }

    [Column("T_ITEM_DISCOUNT")]
    public int? TItemDiscount { get; set; }

    [Column("T_ITEM_TOTAL")]
    public float? TItemTotal { get; set; }

    [Column("T_NOTE")]
    [StringLength(254)]
    [Unicode(false)]
    public string TNote { get; set; }

    [Column("T_REPORT_DIST")]
    [StringLength(255)]
    [Unicode(false)]
    public string TReportDist { get; set; }

    [Column("T_REPORT_PRIMARY")]
    public int? TReportPrimary { get; set; }

    [Column("T_REVISION_NOTE")]
    [StringLength(254)]
    [Unicode(false)]
    public string TRevisionNote { get; set; }

    [Column("T_REVISION_NUMBER")]
    public int? TRevisionNumber { get; set; }

    [Column("T_SURCHARGE_SCHEME")]
    [StringLength(20)]
    [Unicode(false)]
    public string TSurchargeScheme { get; set; }

    [Column("PRE_INVOICE_FORMAT")]
    [StringLength(20)]
    [Unicode(false)]
    public string PreInvoiceFormat { get; set; }

    [Column("T_QUOTE_BODY")]
    [StringLength(254)]
    [Unicode(false)]
    public string TQuoteBody { get; set; }

    [Column("CATALOGUE")]
    [StringLength(20)]
    [Unicode(false)]
    public string Catalogue { get; set; }

    [Column("CATALOGUE_VERSION")]
    public int? CatalogueVersion { get; set; }

    [Column("USE_LATEST_CAT_VER")]
    [StringLength(1)]
    [Unicode(false)]
    public string UseLatestCatVer { get; set; }

    [Column("SEARCH_TEMPLATE")]
    [StringLength(20)]
    [Unicode(false)]
    public string SearchTemplate { get; set; }

    [Column("QUANT_PRICE_IS_DISC")]
    [StringLength(1)]
    [Unicode(false)]
    public string QuantPriceIsDisc { get; set; }

    [Column("CAT_ITEM_DISC")]
    public int? CatItemDisc { get; set; }

    [Column("CAT_ITEM_SUR")]
    public int? CatItemSur { get; set; }

    [Column("T_RECEIPT_DIST")]
    [StringLength(255)]
    [Unicode(false)]
    public string TReceiptDist { get; set; }

    [Column("T_RECEIPT_PRIMARY")]
    public int? TReceiptPrimary { get; set; }

    [Column("T_PROGRAM")]
    [StringLength(30)]
    [Unicode(false)]
    public string TProgram { get; set; }

    [Column("C_MAX_INVOICE_AMOUNT")]
    public double? CMaxInvoiceAmount { get; set; }

    [Column("C_LANGUAGE")]
    [StringLength(20)]
    [Unicode(false)]
    public string CLanguage { get; set; }

    [Column("C_REPORT_GROUP")]
    [StringLength(20)]
    [Unicode(false)]
    public string CReportGroup { get; set; }
}