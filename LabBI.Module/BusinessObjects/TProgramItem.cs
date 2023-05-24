using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("TProgram", "OrderNumber")]
[Table("T_PROGRAM_ITEM")]
//[Index("Product", Name = "idx_T_PROGRAM_ITEM_PRODUCT")]
//[Index("SamplingPoint", Name = "idx_T_PROGRAM_ITEM_SAMPLING_POINT")]
//[Index("Season", Name = "idx_T_PROGRAM_ITEM_SEASON")]
//[Index("TestList", Name = "idx_T_PROGRAM_ITEM_TEST_LIST")]
//[Index("TProgram", Name = "idx_T_PROGRAM_ITEM_T_PROGRAM")]
[DefaultClassOptions]
[NavigationItem("Planning")]
[DefaultProperty("T_PROGRAM")]
public  partial class TProgramItem: BaseObjectNoID
{
    [Key]
    [Column("T_PROGRAM")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TProgram { get; set; }

    [Key]
    [Column("ORDER_NUMBER")]
    public virtual int OrderNumber { get; set; }

    [Column("LOGIN_OFFSET")]
    public virtual int? LoginOffset { get; set; }

    [Column("SAMPLING_POINT")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SamplingPoint { get; set; }

    [Column("C_PACKAGE")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CPackage { get; set; }

    [Column("TEST_LIST")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TestList { get; set; }

    [Column("ANALYSES")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analyses { get; set; }

    [Column("PRODUCT")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Product { get; set; }

    [Column("PRODUCT_GRADE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ProductGrade { get; set; }

    [Column("SEASON")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Season { get; set; }

    [Column("MON_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MonCollect { get; set; }

    [Column("TUES_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TuesCollect { get; set; }

    [Column("WED_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string WedCollect { get; set; }

    [Column("THURS_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ThursCollect { get; set; }

    [Column("FRI_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FriCollect { get; set; }

    [Column("SAT_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SatCollect { get; set; }

    [Column("SUN_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SunCollect { get; set; }

    [Column("WK_1_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Wk1Collect { get; set; }

    [Column("WK_2_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Wk2Collect { get; set; }

    [Column("WK_3_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Wk3Collect { get; set; }

    [Column("WK_4_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Wk4Collect { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("LAST_RUN", TypeName = "datetime")]
    public virtual DateTime? LastRun { get; set; }

    [Column("RUNNING")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Running { get; set; }

    [Column("PHASE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Phase { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("SCHED_RULE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SchedRule { get; set; }

    [Column("WK_5_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Wk5Collect { get; set; }

    [Column("DAY_COLLECT")]
    public virtual int? DayCollect { get; set; }

    [Column("JAN_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string JanCollect { get; set; }

    [Column("FEB_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FebCollect { get; set; }

    [Column("MAR_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MarCollect { get; set; }

    [Column("APR_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AprCollect { get; set; }

    [Column("MAY_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string MayCollect { get; set; }

    [Column("JUN_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string JunCollect { get; set; }

    [Column("JUL_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string JulCollect { get; set; }

    [Column("AUG_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AugCollect { get; set; }

    [Column("SEP_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SepCollect { get; set; }

    [Column("OCT_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OctCollect { get; set; }

    [Column("NOV_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NovCollect { get; set; }

    [Column("DEC_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DecCollect { get; set; }

    [Column("DAYS_AHEAD")]
    public virtual int? DaysAhead { get; set; }

    [Column("SAMPLE_TYPE")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SampleType { get; set; }

    [Column("EARLY_COLLECT_DAYS")]
    public virtual int? EarlyCollectDays { get; set; }

    [Column("LATE_COLLECT_DAYS")]
    public virtual int? LateCollectDays { get; set; }

    [Column("CUSTOMER_COLLECT")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CustomerCollect { get; set; }

    [Column("RETURN_DAYS")]
    public virtual int? ReturnDays { get; set; }

    [Column("DROP_OFF_CONTAINERS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DropOffContainers { get; set; }

    [Column("EARLY_DROP_OFF_DAYS")]
    public virtual int? EarlyDropOffDays { get; set; }

    [Column("LATE_DROP_OFF_DAYS")]
    public virtual int? LateDropOffDays { get; set; }

    [Column("DROP_OFF_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DropOffLocation { get; set; }

    [Column("PICKUP_CONTAINERS")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PickupContainers { get; set; }

    [Column("EARLY_PICKUP_DAYS")]
    public virtual int? EarlyPickupDays { get; set; }

    [Column("LATE_PICKUP_DAYS")]
    public virtual int? LatePickupDays { get; set; }

    [Column("PICKUP_LOCATION")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PickupLocation { get; set; }

    [Column("R4_BASE_DATE", TypeName = "datetime")]
    public virtual DateTime? R4BaseDate { get; set; }

    [Column("R4_DAYS")]
    public virtual int? R4Days { get; set; }

    [Column("C_SAMPLING_REASON")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CSamplingReason { get; set; }

    [Column("C_WEEK_SELECTION")]
    [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CWeekSelection { get; set; }
}