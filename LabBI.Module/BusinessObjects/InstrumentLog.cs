using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("Instrument", "EventType", "EnteredOn")]
[Table("INSTRUMENT_LOG")]
//[Index("Instrument", Name = "INSTRUMENT_LO13930")]
[DefaultClassOptions]
[NavigationItem("Instruments")]
[DefaultProperty("EVENT_TYPE")]
public partial class InstrumentLog
{
    [Key]
    [Column("INSTRUMENT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Instrument { get; set; }

    [Key]
    [Column("EVENT_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EventType { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("LOG_ENTRY", TypeName = "text")]
    public virtual string LogEntry { get; set; }

    [Column("ENTERED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EnteredBy { get; set; }

    [Key]
    [Column("ENTERED_ON", TypeName = "datetime")]
    public DateTime EnteredOn { get; set; }

    [Column("T_CALIB_INTV")]
    public virtual int? TCalibIntv { get; set; }

    [Column("T_SAMPLE_NUMBER")]
    public virtual int? TSampleNumber { get; set; }
}