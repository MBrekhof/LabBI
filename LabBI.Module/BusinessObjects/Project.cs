using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("PROJECT")]
//[Index("ChargeCode", Name = "idx_PROJECT_CHARGE_CODE")]
//[Index("Customer", Name = "idx_Project_Customer")]
[DefaultClassOptions]
[NavigationItem("CRM")]
[DefaultProperty("Name")]
public  partial class Project : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("TEMPLATE_VERSION")]
    public virtual int? TemplateVersion { get; set; }

    [Column("TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Template { get; set; }

    [Column("TITLE")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("NOTE")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Note { get; set; }

    [Column("STATUS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Status { get; set; }

    [Column("OLD_STATUS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OldStatus { get; set; }

    [Column("DATE_CREATED", TypeName = "datetime")]
    public virtual DateTime? DateCreated { get; set; }

    [Column("DATE_RECEIVED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateReceived { get; set; }

    [Column("DATE_STARTED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateStarted { get; set; }

    [Column("DATE_COMPLETED", TypeName = "datetime")]
    public virtual DateTime? DateCompleted { get; set; }

    [Column("DATE_REVIEWED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateReviewed { get; set; }

    [Column("DATE_UPDATED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateUpdated { get; set; }

    [Column("COST_FACTOR")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual float? CostFactor { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]

    public virtual string Customername { get; set; }
    public virtual Customer Customer { get; set; }

    [Column("CUSTOMER_CONTACT")]
    [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CustomerContact { get; set; }

    [Column("OWNER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Owner { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CreatedBy { get; set; }

    [Column("NUM_SAMPLES")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? NumSamples { get; set; }

    [Column("NUM_U")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumU { get; set; }

    [Column("NUM_I")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumI { get; set; }

    [Column("NUM_P")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumP { get; set; }

    [Column("NUM_C")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumC { get; set; }

    [Column("NUM_A")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumA { get; set; }

    [Column("NUM_R")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumR { get; set; }

    [Column("NUM_X")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? NumX { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("CLOSED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Closed { get; set; }

    [Column("SAMPLE_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleTemplate { get; set; }

    [Column("CONCLUSION")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Conclusion { get; set; }

    [Column("PRODUCT")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Product { get; set; }

    [Column("STABILITY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Stability { get; set; }

    [Column("CHARGE_CODE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChargeCode { get; set; }

    [Column("USE_GROUP_LOGIN")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UseGroupLogin { get; set; }

    [Column("BATCH_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchTemplate { get; set; }

    [Column("USE_GRID_LOGIN")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string UseGridLogin { get; set; }

    [Column("CUSTOMER_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CustomerTemplate { get; set; }

    [Column("OWNER_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OwnerLocation { get; set; }

    [Column("ALIQUOT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Aliquot { get; set; }

    [Column("SIGNED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Signed { get; set; }

    [Column("T_CERTIFICATION")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCertification { get; set; }

    [Column("T_CLOSED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TClosedBy { get; set; }

    [Column("T_CLOSED_ON", TypeName = "datetime")]
    public virtual DateTime? TClosedOn { get; set; }

    [Column("T_COA_COMMENT")]
    public virtual int? TCoaComment { get; set; }

    [Column("T_COA_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCoaTemplate { get; set; }

    [Column("T_CONTRACT_NUMBER")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TContractNumber { get; set; }

    [Column("T_COPY_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCopyTemplate { get; set; }

    [Column("T_CUST_MANIFEST")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCustManifest { get; set; }

    [Column("T_CUSTOMER_GROUP")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCustomerGroup { get; set; }

    [Column("T_INVOICE_NUMBER")]
    public virtual int? TInvoiceNumber { get; set; }

    [Column("T_LOGIN_VERIF_REQD")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLoginVerifReqd { get; set; }

    [Column("T_LOGIN_VERIFIED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLoginVerified { get; set; }

    [Column("T_LOGIN_VERIFIED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TLoginVerifiedBy { get; set; }

    [Column("T_LOGIN_VERIFIED_ON", TypeName = "datetime")]
    public virtual DateTime? TLoginVerifiedOn { get; set; }

    [Column("T_NOTE")]
    public virtual int? TNote { get; set; }

    [Column("T_PO_NUMBER")]
    [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPoNumber { get; set; }

    [Column("T_SOURCE_CUSTOMER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TSourceCustomer { get; set; }

    [Column("T_PRE_INVOICE_NUMBER")]
    public virtual int? TPreInvoiceNumber { get; set; }

    [Column("T_PRIORITY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPriority { get; set; }

    [Column("T_STATUS")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TStatus { get; set; }

    [Column("T_ZERO_TEST_CHARGE")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TZeroTestCharge { get; set; }

    [Column("T_COA_COMPLETE")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCoaComplete { get; set; }

    [Column("T_CATALOGUE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCatalogue { get; set; }

    [Column("T_CATALOGUE_VERSION")]
    public virtual int? TCatalogueVersion { get; set; }

    [Column("T_RECEIPT_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReceiptTemplate { get; set; }

    [Column("FACILITY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Facility { get; set; }

    [Column("T_COA_REQ")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCoaReq { get; set; }

    [Column("T_INVOICE_REQ")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoiceReq { get; set; }

    [Column("T_CONTACTS_REQ")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TContactsReq { get; set; }

    [Column("T_END_PERIOD", TypeName = "datetime")]
    public virtual DateTime? TEndPeriod { get; set; }

    [Column("T_PROGRAM")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TProgram { get; set; }

    [Column("T_START_PERIOD", TypeName = "datetime")]
    public virtual DateTime? TStartPeriod { get; set; }

    [Column("C_EXTERNAL_REFERENCE")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CExternalReference { get; set; }

    [Column("C_SAMPLING_BY")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CSamplingBy { get; set; }

    [Column("C_LANGUAGE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CLanguage { get; set; }

    [Column("C_FIXEDPRICE")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CFixedprice { get; set; }

    [Column("C_FIXEDAMOUNT", TypeName = "decimal(18, 2)")]
    public virtual decimal? CFixedamount { get; set; }

    [Column("C_EMAILTO")]
    [StringLength(80)]
    public virtual string CEmailto { get; set; }

    [Column("C_REPORTS_TO")]
    [StringLength(80)]
    public virtual string CReportsTo { get; set; }

    [Column("C_INVOICE_TO")]
    [StringLength(80)]
    public virtual string CInvoiceTo { get; set; }
}