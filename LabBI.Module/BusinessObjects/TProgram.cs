using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LabBI.Module.BusinessObjects;

[Table("T_PROGRAM")]
public  partial class TProgram: BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("FIRST_DAY_OF_WEEK")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FirstDayOfWeek { get; set; }

    [Column("TREAT_HOLIDAYS_AS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TreatHolidaysAs { get; set; }

    [Column("NEEDS_RELOADING")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NeedsReloading { get; set; }

    [Column("WORKSTATION")]
    [StringLength(30)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Workstation { get; set; }

    [Column("RUNNING")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Running { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GUI_CONFIG", TypeName = "text")]
    public virtual string GuiConfig { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Customer { get; set; }

    [Column("START_DATE", TypeName = "datetime")]
    public virtual DateTime? StartDate { get; set; }

    [Column("END_DATE", TypeName = "datetime")]
    public virtual DateTime? EndDate { get; set; }

    [Column("CONTRACT_NUMBER")]
    public virtual int? ContractNumber { get; set; }

    [Column("STATUS")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Status { get; set; }

    [Column("WS_INSERT_DATE", TypeName = "datetime")]
    public virtual DateTime? WsInsertDate { get; set; }

    [Column("REPORT_FREQUENCY")]
    public virtual int? ReportFrequency { get; set; }

    [Column("PROJECT_TEMPLATE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ProjectTemplate { get; set; }

    [Column("RELOAD_WATER_SCHED")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReloadWaterSched { get; set; }

    [Column("WS_LAST_DATE", TypeName = "datetime")]
    public virtual DateTime? WsLastDate { get; set; }

    [Column("DATAFILE")]
    [StringLength(255)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Datafile { get; set; }

    [Column("VALIDATION_MSG")]
    public virtual int? ValidationMsg { get; set; }

    [Column("ERROR_MSG")]
    public virtual int? ErrorMsg { get; set; }
}