using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects
{

    [DefaultClassOptions]
    [NavigationItem("Analysis")]
    [DefaultProperty("Name")]

    [Table("ANALYSIS")]
    [PrimaryKey(nameof(Name), nameof(Version))]
    public  class Analysis : BaseObjectNoID
    {
        [VisibleInListView(true), VisibleInLookupListView(true)]
        [Column("NAME"), MaxLength(20), Required]

        public virtual string Name { get; set; }

        [VisibleInListView(true), VisibleInLookupListView(true)]
        [Column("VERSION")]

        public virtual int Version { get; set; }

        [VisibleInListView(true), VisibleInLookupListView(true)]
        [Column("GROUP_NAME"), MaxLength(20)]

        public virtual string GroupName { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("ACTIVE"), MaxLength(1)]
        public virtual string Active { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("REPORTED_NAME"), MaxLength(30)]
        public virtual string ReportedName { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("COMMON_NAME"), MaxLength(20)]
        public virtual string CommonName { get; set; }

        [VisibleInListView(true), VisibleInLookupListView(true)]
        [Column("ANALYSIS_TYPE"), MaxLength(20)]
        public virtual string AnalysisType { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("DESCRIPTION"), MaxLength(254)]
        public virtual string Description { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("ALIAS_NAME"), MaxLength(40)]
        public virtual string AliasName { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("LAB"), MaxLength(20)]
        public virtual string Lab { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("INST_GROUP"), MaxLength(20)]
        public virtual string InstGroup { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("INSTRUMENT"), MaxLength(20)]
        public virtual string Instrument { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("TEST_LOCATION"), MaxLength(20)]
        public virtual string TestLocation { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("EXPECTED_DATE")]
        public virtual int? ExpectedDate { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("COST_UNITS")]
        public virtual float? CostUnits { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("REQD_VOLUME")]
        public virtual float? ReqdVolume { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("DESTRUCTIVE"), MaxLength(1)]
        public virtual string Destructive { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("PARAMETER_NAME"), MaxLength(20)]
        public virtual string ParameterName { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("PARAMETER_TAG"), MaxLength(50)]

        public virtual string ParameterTag { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("DISPLAY_MESSAGE"), MaxLength(60)]

        public virtual string DisplayMessage { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("KEY_CONTACT"), MaxLength(20)]
        public virtual string KeyContact { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("CHANGED_ON", TypeName = "datetime")]

        public virtual DateTime? ChangedOn { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("CHANGED_BY"), MaxLength(20)]
        public virtual string ChangedBy { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("REMOVED"), MaxLength(1)]
        public virtual string Removed { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("EXT_LINK"), MaxLength(254)]
        public virtual string ExtLink { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("TEST_TEMPLATE"), MaxLength(20)]
        public virtual string TestTemplate { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("BATCH_LINK"), MaxLength(20)]
        public virtual string BatchLink { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("AUTO_AUTHORIZE"), MaxLength(1)]
        public virtual string AutoAuthorize { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("AUTO_REJECT"), MaxLength(1)]
        public virtual string AutoReject { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("CALC_ON_SAVE"), MaxLength(1)]
        public virtual string CalcOnSave { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("STORE_INCMP_OPTS"), MaxLength(1)]
        public virtual string StoreIncmpOpts { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("ALIQUOT_GROUP"), MaxLength(50)]
        public virtual string AliquotGroup { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("SPLIT_REPLICATES"), MaxLength(1)]
        public virtual string SplitReplicates { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("CROSS_SAMPLE"), MaxLength(1)]
        public virtual string CrossSample { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("SAMPLE_TYPE"), MaxLength(20)]
        public virtual string SampleType { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("CONTAINER_TYPE"), MaxLength(20)]

        public virtual string ContainerType { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("STORAGE_CONDITION"), MaxLength(20)]

        public virtual string StorageCondition { get; set; }

        [VisibleInListView(false), VisibleInLookupListView(false)]
        [Column("APPROVAL_ROLE"), MaxLength(20)]

        public virtual string ApprovalRole { get; set; }

        [Column("QUICK_CODE", TypeName = "varchar(5)")]
        [MaxLength(5)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string QuickCode { get; set; }

        [Column("VOLUME_UNITS", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string VolumeUnits { get; set; }

        [Column("HIDE_ON_ORDER_FORM", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string HideOnOrderForm { get; set; }

        [Column("TEST_SEQUENCE_NO", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TestSequenceNo { get; set; }

        [Column("DOUBLE_ENTRY", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string DoubleEntry { get; set; }

        [Column("TRANSFER_USES_INST", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TransferUsesInst { get; set; }

        [Column("ATTRIBUTE_1", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Attribute1 { get; set; }

        [Column("ATTRIBUTE_2", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Attribute2 { get; set; }

        [Column("ATTRIBUTE_3", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Attribute3 { get; set; }

        [Column("ATTRIBUTE_4", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Attribute4 { get; set; }

        [Column("ATTRIBUTE_5", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string Attribute5 { get; set; }
        [Column("COLLECTION_METHOD", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CollectionMethod { get; set; }
        [Column("COLLECTION_OFFSET", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? CollectionOffset { get; set; }

        [Column("READY_FOR_APPROVAL", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string ReadyForApproval { get; set; }

        [Column("REQUIRES_APPROVAL", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
        public virtual string RequiresApproval { get; set; }
        [Column("T_ALLOWED_PRODUCT", TypeName = "varchar(255)")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TAllowedProduct { get; set; }

        [Column("T_ALLOWED_SAM_TYPE", TypeName = "varchar(255)")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TAllowedSamType { get; set; }

        [Column("T_ANALYSIS_METHOD", TypeName = "varchar(30)")]
        [MaxLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TAnalysisMethod { get; set; }

        [Column("T_CONTAINER_GROUP", TypeName = "varchar(50)")]
        [MaxLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TContainerGroup { get; set; }

        [Column("T_IS_PREP", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TIsPrep { get; set; }

        [Column("T_ONSITE_FLAG", TypeName = "varchar(1)")]
        [MaxLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TOnsiteFlag { get; set; }

        [Column("T_PREP_ANALYSIS", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPrepAnalysis { get; set; }

        [Column("T_PREP_ANALYSIS_GRP", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPrepAnalysisGrp { get; set; }

        [Column("T_PRINT_ORDER", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? TPrintOrder { get; set; }

        [Column("T_REPORT_HEADER", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TReportHeader { get; set; }

        [Column("T_SHORT_NAME", TypeName = "varchar(17)")]
        [MaxLength(17)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TShortName { get; set; }

        [Column("T_UNCERTAINTY_FORM", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TUncertaintyForm { get; set; }

        [Column("T_UNCERTAINTY_VALUE", TypeName = "varchar(255)")]
        [MaxLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TUncertaintyValue { get; set; }

        [Column("QUESTION_SET", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string QuestionSet { get; set; }

        [Column("T_PREREQ_CLEAR_STATUS", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string TPrereqClearStatus { get; set; }

        [Column("LAB_TYPE", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string LabType { get; set; }

        [Column("C_INCUBATION_TIME", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? CIncubationTime { get; set; }

        [Column("C_INCUBATION_TIME_DEV", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? CIncubationTimeDev { get; set; }

        [Column("C_CONSERVATION_TIME", TypeName = "int")]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual int? CConservationTime { get; set; }

        [Column("C_DESCRIPTION_EN", TypeName = "varchar(254)")]
        [MaxLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
        public virtual string CDescriptionEn { get; set; }
    }
}
