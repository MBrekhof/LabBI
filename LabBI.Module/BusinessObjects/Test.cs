using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("TEST")]
//[Index("Analysis", Name = "idxTEST_ANALYSIS")]
//[Index("Batch", Name = "idxTEST_BATCH")]
//[Index("PreInvoiceNumber", "Status", Name = "idxTEST_PREINVOICE")]
//[Index("SampleNumber", Name = "idxTEST_SAMPLENUMBER")]
//[Index("Status", Name = "ridxTEST_STATUS")]
[DefaultClassOptions]
[NavigationItem("Samples")]
[DefaultProperty("Name")]
public  partial class Test: BaseObjectNoID
{
    [Column("SAMPLE_NUMBER")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? SampleNumber { get; set; }

    [Key]
    [Column("TEST_NUMBER")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int TestNumber { get; set; }

    [Column("ORDER_NUMBER")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? OrderNumber { get; set; }

    [Column("ANALYSIS")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    [StringLength(20)]
    public virtual string Analysis { get; set; }

    [Column("VERSION")]
    public virtual int? Version { get; set; }

    [Column("ANALYSIS_COUNT")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? AnalysisCount { get; set; }

    [Column("VARIATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Variation { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("REPORTED_NAME")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportedName { get; set; }

    [Column("REPLICATE_COUNT")]
    public virtual int? ReplicateCount { get; set; }

    [Column("STATUS")]

    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Status { get; set; }

    [Column("OLD_STATUS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OldStatus { get; set; }

    [Column("BATCH_PARENT_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? BatchParentTest { get; set; }

    [Column("BATCH_SIBLING_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? BatchSiblingTest { get; set; }

    [Column("PARENT_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? ParentTest { get; set; }

    [Column("ORIGINAL_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? OriginalTest { get; set; }

    [Column("DATE_RECEIVED", TypeName = "datetime")]
    public virtual DateTime? DateReceived { get; set; }

    [Column("DATE_STARTED", TypeName = "datetime")]
    public virtual DateTime? DateStarted { get; set; }

    [Column("ASSIGNED_OPERATOR")]

    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AssignedOperator { get; set; }

    [Column("PREP")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Prep { get; set; }

    [Column("PREP_DATE", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? PrepDate { get; set; }

    [Column("PREP_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PrepBy { get; set; }

    [Column("DATE_COMPLETED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateCompleted { get; set; }

    [Column("DATE_REVIEWED", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? DateReviewed { get; set; }

    [Column("REVIEWER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Reviewer { get; set; }

    [Column("REPLICATE_TEST")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReplicateTest { get; set; }

    [Column("INSTRUMENT")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Instrument { get; set; }

    [Column("TEST_PRIORITY")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TestPriority { get; set; }

    [Column("IN_SPEC")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InSpec { get; set; }

    [Column("IN_CAL")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InCal { get; set; }

    [Column("TEST_COMMENT")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestComment { get; set; }

    [Column("TEST_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestLocation { get; set; }

    [Column("PARAMETER_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParameterName { get; set; }

    [Column("PARAMETER_VALUE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParameterValue { get; set; }

    [Column("EXPECTED_DATE", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? ExpectedDate { get; set; }

    [Column("LAB")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Lab { get; set; }

    [Column("RESOLVE_REQD")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ResolveReqd { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

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

    [Column("IN_CONTROL")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InControl { get; set; }

    [Column("TEST_LIST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestList { get; set; }

    [Column("RE_TESTED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReTested { get; set; }

    [Column("MODIFIED_RESULTS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ModifiedResults { get; set; }

    [Column("ALIQUOTED_TO")]
    public virtual int? AliquotedTo { get; set; }

    [Column("ON_WORKSHEET")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OnWorksheet { get; set; }

    [Column("DISP_FLDS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DispFlds { get; set; }

    [Column("DISPLAY_RESULTS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DisplayResults { get; set; }

    [Column("ALIQUOT_GROUP")]
    [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AliquotGroup { get; set; }

    [Column("SPLIT_REPLICATES")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SplitReplicates { get; set; }

    [Column("CROSS_SAMPLE")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CrossSample { get; set; }

    [Column("RELEASED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Released { get; set; }

    [Column("RELEASED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReleasedBy { get; set; }

    [Column("RELEASED_ON", TypeName = "datetime")]
    public virtual DateTime? ReleasedOn { get; set; }

    [Column("RELEASE_COMMENT")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReleaseComment { get; set; }

    [Column("DOUBLE_ENTRY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DoubleEntry { get; set; }

    [Column("CHILD_OUT_SPEC")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChildOutSpec { get; set; }

    [Column("CHARGE_ENTRY")]
    public virtual int? ChargeEntry { get; set; }

    [Column("SIGNED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Signed { get; set; }

    [Column("BATCH_ORIGINAL_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? BatchOriginalTest { get; set; }

    [Column("TEST_SEQUENCE_NO")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TestSequenceNo { get; set; }

    [Column("INVOICE_NUMBER")]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual int? InvoiceNumber { get; set; }

    [Column("BILLING_ITEM_DESC")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BillingItemDesc { get; set; }

    [Column("CNTRCT_QTE_ITEM_NO")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? CntrctQteItemNo { get; set; }

    [Column("REPORTED_RSLT_OOS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportedRsltOos { get; set; }

    [Column("CONTAINER_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ContainerType { get; set; }

    [Column("DOUBLE_BLIND")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DoubleBlind { get; set; }

    [Column("PRE_INVOICE_NUMBER")]
    public virtual int? PreInvoiceNumber { get; set; }

    [Column("T_ALLOWED_PRODUCT")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAllowedProduct { get; set; }

    [Column("T_ALLOWED_SAM_TYPE")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAllowedSamType { get; set; }

    [Column("T_ANALYSIS_METHOD")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TAnalysisMethod { get; set; }

    [Column("T_CHARGE_GROUP")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TChargeGroup { get; set; }

    [Column("T_CLIENT_DUE_DATE", TypeName = "datetime")]
    public virtual DateTime? TClientDueDate { get; set; }

    [Column("T_CLIENT_PRIORITY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TClientPriority { get; set; }

    [Column("T_CLIENT_TURNARUND")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TClientTurnarund { get; set; }

    [Column("T_CONTAINER_GROUP")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TContainerGroup { get; set; }

    [Column("T_DATE_ENABLED", TypeName = "datetime")]
    public virtual DateTime? TDateEnabled { get; set; }

    [Column("T_INST_TESTS")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInstTests { get; set; }

    [Column("T_LAB_DUE_DATE", TypeName = "datetime")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual DateTime? TLabDueDate { get; set; }

    [Column("T_PREP_ANALYSIS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrepAnalysis { get; set; }

    [Column("T_PREP_ANALYSIS_GRP")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrepAnalysisGrp { get; set; }

    [Column("T_PREP_TEST")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TPrepTest { get; set; }

    [Column("T_QC_REFERENCE")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TQcReference { get; set; }

    [Column("T_REPORT_HEADER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReportHeader { get; set; }

    [Column("T_TURNAROUND_ACTUA")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TTurnaroundActua { get; set; }

    [Column("T_TURNAROUND_CHARG")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? TTurnaroundCharg { get; set; }

    [Column("T_TURNAROUND_MET")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TTurnaroundMet { get; set; }

    [Column("ANALYSIS_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AnalysisType { get; set; }

    [Column("COMMON_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CommonName { get; set; }

    [Column("T_INVOICE_TEST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoiceTest { get; set; }

    [Column("T_SHIP_REQUEST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TShipRequest { get; set; }

    [Column("ANSWER_SET")]
    public virtual int? AnswerSet { get; set; }

    [Column("T_REPORT_GROUP")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReportGroup { get; set; }

    [Column("T_PREREQ_CLEARED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrereqCleared { get; set; }

    [Column("T_FACILITY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TFacility { get; set; }

    [Column("T_NEEDS_FACILITY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TNeedsFacility { get; set; }

    [Column("LAB_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string LabType { get; set; }

    [Column("REQD_VOLUME")]
    public virtual int? ReqdVolume { get; set; }

    [Column("T_NORMAL_CONTAINER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TNormalContainer { get; set; }

    [Column("C_DISCLAIMER")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CDisclaimer { get; set; }

    [Column("C_PACKAGE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CPackage { get; set; }

    [Column("AUDIT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Audit { get; set; }

    [Column("METHOD")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Method { get; set; }

    [Column("METHOD_VERSION")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? MethodVersion { get; set; }

    [Column("C_CONSERVATION_TIME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual int? CConservationTime { get; set; }
}