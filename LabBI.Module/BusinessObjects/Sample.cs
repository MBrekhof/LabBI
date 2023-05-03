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
    [NavigationItem("Samples")]
    [DefaultProperty("SampleNumber")]
    public  class Sample : BaseObjectNoID
    {
        [Key]
        [Column("SAMPLE_NUMBER")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual int SampleNumber { get; set; }


        [Column("TEXT_ID", TypeName = "varchar(30)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string TextId { get; set; }

        [Column("STATUS", TypeName = "varchar(1)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string Status { get; set; }

        [Column("OLD_STATUS", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string OldStatus { get; set; }

        [Column("DISP_FLDS", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string DispFlds { get; set; }

        [Column("LABEL_MASK", TypeName = "varchar(100)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LabelMask { get; set; }

        [Column("IN_SPEC", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InSpec { get; set; }

        [Column("IN_CAL", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InCal { get; set; }

        [Column("CHANGED_ON", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? ChangedOn { get; set; }

        [Column("RE_SAMPLE", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReSample { get; set; }

        [Column("ALIQUOT", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Aliquot { get; set; }

        [Column("ORIGINAL_SAMPLE", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? OriginalSample { get; set; }

        [Column("PARENT_SAMPLE", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ParentSample { get; set; }

        [Column("PARENT_ALIQUOT", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ParentAliquot { get; set; }

        [Column("ALIQUOT_GROUP", TypeName = "varchar(50)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AliquotGroup { get; set; }

        [Column("SAMPLE_VOLUME", TypeName = "real")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual float? SampleVolume { get; set; }

        [Column("SAMPLE_UNITS", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SampleUnits { get; set; }

        [Column("LOGIN_DATE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? LoginDate { get; set; }

        [Column("LOGIN_BY", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LoginBy { get; set; }

        [Column("SAMPLED_DATE", TypeName = "datetime")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual DateTime? SampledDate { get; set; }

        [Column("RECD_DATE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? RecdDate { get; set; }

        [Column("RECEIVED_BY", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReceivedBy { get; set; }

        [Column("DATE_STARTED", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? DateStarted { get; set; }

        [Column("STARTED", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Started { get; set; }

        [Column("ASSIGNED_OPERATOR", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AssignedOperator { get; set; }

        [Column("DUE_DATE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? DueDate { get; set; }

        [Column("DATE_COMPLETED", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? DateCompleted { get; set; }

        [Column("DATE_REVIEWED", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? DateReviewed { get; set; }

        [Column("PREP", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Prep { get; set; }
        [Column("PREP_DATE", TypeName = "datetime")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? PrepDate { get; set; }

        [Column("PREP_BY", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string PrepBy { get; set; }

        [Column("REVIEWER", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Reviewer { get; set; }

        [Column("REVIEW_NOTE", TypeName = "varchar(254)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReviewNote { get; set; }

        [Column("PRODUCT_CODE", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ProductCode { get; set; }

        [Column("PRODUCT", TypeName = "varchar(50)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Product { get; set; }

        [Column("PRODUCT_VERSION", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ProductVersion { get; set; }

        [Column("PRODUCT_GRADE", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ProductGrade { get; set; }

        [Column("SAMPLING_POINT", TypeName = "varchar(20)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string SamplingPoint { get; set; }

        [Column("SAMPLE_TYPE", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SampleType { get; set; }

        [Column("PROJECT", TypeName = "varchar(20)")]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string Project { get; set; }

        [Column("BATCH_NAME", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string BatchName { get; set; }

        [Column("BATCH_TEMPLATE", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string BatchTemplate { get; set; }

        [Column("STEP", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Step { get; set; }

        [Column("SAMPLE_NAME", TypeName = "varchar(30)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SampleName { get; set; }

        [Column("DESCRIPTION", TypeName = "varchar(254)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Description { get; set; }

        [Column("PRIORITY", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? Priority { get; set; }

        [Column("LOCATION", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Location { get; set; }

        [Column("CUSTOMER", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Customer { get; set; }

        [Column("TEST_LIST", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TestList { get; set; }

        [Column("TEMPLATE", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Template { get; set; }

        [Column("RECIPIENT", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Recipient { get; set; }

        [Column("STANDARD", TypeName = "varchar(1)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Standard { get; set; }

        [Column("EXT_LINK", TypeName = "varchar(254)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ExtLink { get; set; }

        [Column("CONDITION", TypeName = "varchar(20)")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Condition { get; set; }

        [Column("TIMEPOINT")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Timepoint { get; set; }

        [Column("LOT")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? Lot { get; set; }

        [Column("BASE_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? BaseDate { get; set; }

        [Column("AVAILABLE_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? AvailableDate { get; set; }

        [Column("REQUIRED_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? RequiredDate { get; set; }

        [Column("TARGET_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TargetDate { get; set; }

        [Column("PARTIAL_SPEC")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string PartialSpec { get; set; }

        [Column("SPEC_TYPE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SpecType { get; set; }

        [Column("STAGE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Stage { get; set; }

        [Column("PRIMARY_IN_SPEC")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string PrimaryInSpec { get; set; }

        [Column("BATCH")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Batch { get; set; }

        [Column("CHARGE_CODE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ChargeCode { get; set; }

        [Column("FORMULATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Formulation { get; set; }

        [Column("PROTOCOL_LEVEL")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ProtocolLevel { get; set; }

        [Column("RELEASED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Released { get; set; }

        [Column("RELEASED_BY")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReleasedBy { get; set; }

        [Column("RELEASED_ON")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? ReleasedOn { get; set; }

        [Column("IN_CONTROL")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string InControl { get; set; }

        [Column("INVESTIGATION")]
        [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Investigation { get; set; }

        [Column("INVESTIGATED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Investigated { get; set; }

        [Column("APPROVED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Approved { get; set; }

        [Column("APPROVAL_GROUP")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ApprovalGroup { get; set; }

        [Column("READY_FOR_APPROVAL")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReadyForApproval { get; set; }

        [Column("APPROVAL_ID")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ApprovalId { get; set; }

        [Column("APPROVAL_ROUTING")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ApprovalRouting { get; set; }

        [Column("MODIFIED_RESULTS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ModifiedResults { get; set; }

        [Column("REPORT_NUMBER")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ReportNumber { get; set; }

        [Column("COMPOSITE")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Composite { get; set; }

        [Column("PARENT_COMPOSITE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ParentComposite { get; set; }

        [Column("COMPOSITE_TEMPLATE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CompositeTemplate { get; set; }

        [Column("SEASON_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? SeasonDate { get; set; }

        [Column("PEOPLE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? People { get; set; }

        [Column("TEST_LOCATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TestLocation { get; set; }

        [Column("OWNER_LOCATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string OwnerLocation { get; set; }

        [Column("CHK_ALIQUOT_STATUS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ChkAliquotStatus { get; set; }

        [Column("CHK_ALIQUOT_SPECS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ChkAliquotSpecs { get; set; }

        [Column("ALIQUOT_TEMPLATE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AliquotTemplate { get; set; }

        [Column("CALC_GROUP")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CalcGroup { get; set; }

        [Column("SAMPLE_EVENT")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? SampleEvent { get; set; }

        [Column("LABEL_ID")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LabelId { get; set; }

        [Column("HAS_FLAGS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string HasFlags { get; set; }

        [Column("VARIATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Variation { get; set; }

        [Column("SAMPLED_BY")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SampledBy { get; set; }
        [Column("SAMPLED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Sampled { get; set; }

        [Column("ORDER_NUM")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string OrderNum { get; set; }

        [Column("LAST_ORDER_NUM")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LastOrderNum { get; set; }

        [Column("STORAGE_CONDITION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string StorageCondition { get; set; }

        [Column("CONTAINER_TYPE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ContainerType { get; set; }

        [Column("NUM_CONTAINERS")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? NumContainers { get; set; }

        [Column("IMPORTANT_MESSAGE")]
        [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ImportantMessage { get; set; }

        [Column("OBSERVATIONS")]
        [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Observations { get; set; }

        [Column("LAB")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Lab { get; set; }

        [Column("EXPIRATION_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? ExpirationDate { get; set; }

        [Column("REQD_VOLUME")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual float? ReqVolume { get; set; }

        [Column("COLLECTION_METHOD")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CollectionMethod { get; set; }

        [Column("COLLECTION_OFFSET")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? CollectionOffset { get; set; }

        [Column("SIGNED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Signed { get; set; }

        [Column("ALLOW_CHLD_ALQTS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AllowChldAlqts { get; set; }

        [Column("CONTRACT_NUMBER")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? ContractNumber { get; set; }

        [Column("BILLING_ITEM_DESC")]
        [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string BillingItemDesc { get; set; }

        [Column("STORAGE_LOC_NO")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? StorageLocNo { get; set; }

        [Column("EXTERNAL_LOCATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ExternalLocation { get; set; }

        [Column("STORAGE_TEMPLATE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string StorageTemplate { get; set; }

        [Column("CONVERSION_GROUPS")]
        [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ConversionGroups { get; set; }

        [Column("REPORTED_RSLT_OOS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReportedRsltOos { get; set; }

        [Column("T_CONTRACT_TESTS")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TContractTests { get; set; }

        [Column("T_CUSTOMER_GROUP")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCustomerGroup { get; set; }

        [Column("T_DEPTH")]
        [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TDepth { get; set; }

        [Column("T_DISPOSAL_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TDisposalDate { get; set; }

        [Column("T_INSTRUMENT")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TInstrument { get; set; }

        [Column("T_LOGIN_VERIFIED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TLoginVerified { get; set; }

        [Column("T_NOTE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TNote { get; set; }

        [Column("T_RETURN_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TReturnDate { get; set; }

        [Column("T_SAMPLE_ID")]
        [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TSampleId { get; set; }

        [Column("T_ADDRESS_DETAILS")]
        [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TAddressDetails { get; set; }
        [Column("T_CUSTOMER_REF")]
        [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCustomerRef { get; set; }

        [Column("T_REGULATION_TYPE")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TRegulationType { get; set; }

        [Column("T_SAMPLE_COMMENT")]
        [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TSampleComment { get; set; }

        [Column("T_SAMPLING_REASON")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TSamplingReason { get; set; }

        [Column("T_WATER_QUALITY")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TWaterQuality { get; set; }

        [Column("FACILITY")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Facility { get; set; }

        [Column("COLLECTION_RUN")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CollectionRun { get; set; }

        [Column("SAMPLER_ID")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SamplerId { get; set; }

        [Column("COLLECTION_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? CollectionDate { get; set; }

        [Column("FORMULATION_NAME")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string FormulationName { get; set; }

        [Column("T_CUSTOMER_COLLECT")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCustomerCollect { get; set; }

        [Column("T_DISPATCH_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TDispatchDate { get; set; }

        [Column("T_DROPOFF_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TDropoffDate { get; set; }

        [Column("T_DROPOFF_LOCATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TDropoffLocation { get; set; }

        [Column("T_EARLY_COLLECT_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TEarlyCollectDate { get; set; }

        [Column("T_EARLY_DROPOFF_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TEarlyDropoffDate { get; set; }

        [Column("T_EARLY_PICKUP_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TEarlyPickupDate { get; set; }

        [Column("T_IDEAL_COLLECT_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TIdealCollectDate { get; set; }

        [Column("T_LATE_COLLECT_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TLateCollectDate { get; set; }

        [Column("T_LATE_DROPOFF_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TLateDropoffDate { get; set; }

        [Column("T_LATE_PICKUP_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TLatePickupDate { get; set; }

        [Column("T_PICKUP_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TPickupDate { get; set; }

        [Column("T_PICKUP_LOCATION")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPickupLocation { get; set; }

        [Column("T_PICKUP_RUN")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPickupRun { get; set; }

        [Column("T_RUN_AVAILABLE")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TRunAvailable { get; set; }

        [Column("T_RUN_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TRunDate { get; set; }

        [Column("T_RUN_PICKUP_DATE")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? TRunPickupDate { get; set; }

        [Column("T_SP_PICKUPRUN_ORDER")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TSpPickupRunOrder { get; set; }

        [Column("T_SP_RUN_ORDER")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TSpRunOrder { get; set; }

        [Column("C_SAMPLED_TIME")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CSampledTime { get; set; }

        [Column("C_CUSTOMER_REMARK")]
        [StringLength(500)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CCustomerRemark { get; set; }

        [Column("C_DISCLAIMER")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CDisclaimer { get; set; }

        [Column("AUDIT")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Audit { get; set; }

        [Column("SPEC_LIST")]
        [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string SpecList { get; set; }

        [Column("SPEC_LIST_VERSION")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? SpecListVersion { get; set; }

        [Column("AUDIT_REVIEWED_BY")]
        [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AuditReviewedBy { get; set; }

        [Column("NEEDS_AUDIT_REVIEW")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string NeedsAuditReview { get; set; }

        [Column("AUDIT_REVIEW_NOTES", TypeName = "text")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AuditReviewNotes { get; set; }

        [Column("AUDIT_REVIEWED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string AuditReviewed { get; set; }

        [Column("AUDIT_REVIEWED_ON")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual DateTime? AuditReviewedOn { get; set; }

        [Column("TRACK_CHANGES")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TrackChanges { get; set; }

        [Column("T_COLLECTED")]
        [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TCollected { get; set; }

        [Column("T_LATLONG")]
        [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TLatLong { get; set; }

        [Column("T_LOGD_LATLONG")]
        [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TLogdLatLong { get; set; }

        [Column("T_RECD_LATLONG")]
        [StringLength(40)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TRecdLatLong { get; set; }
    }
}
