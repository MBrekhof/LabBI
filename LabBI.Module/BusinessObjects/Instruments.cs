using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("INSTRUMENTS")]
[DefaultClassOptions]
[NavigationItem("Instruments")]
[DefaultProperty("NAME")]
public partial class Instruments
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("INST_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InstGroup { get; set; }

    [Column("ON_LINE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string OnLine { get; set; }

    [Column("LOCATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Location { get; set; }

    [Column("OPERATOR")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Operator { get; set; }

    [Column("VENDOR")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Vendor { get; set; }

    [Column("SERIAL_NO")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SerialNo { get; set; }

    [Column("PM_DATE", TypeName = "datetime")]
    public virtual DateTime? PmDate { get; set; }

    [Column("PM_INTV")]
    public virtual int? PmIntv { get; set; }

    [Column("PM_EXPIRATION", TypeName = "datetime")]
    public virtual DateTime? PmExpiration { get; set; }

    [Column("CALIB_DATE", TypeName = "datetime")]
    public virtual DateTime? CalibDate { get; set; }

    [Column("CALIB_INTV")]
    public virtual int? CalibIntv { get; set; }

    [Column("CALIB_EXPIRATION", TypeName = "datetime")]
    public virtual DateTime? CalibExpiration { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("LINK_LOCATION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string LinkLocation { get; set; }

    [Column("PARAMETER_1_NAME")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter1Name { get; set; }

    [Column("PARAMETER_1_VALUE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter1Value { get; set; }

    [Column("PARAMETER_2_NAME")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter2Name { get; set; }

    [Column("PARAMETER_2_VALUE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parameter2Value { get; set; }

    [Column("LABSTATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Labstation { get; set; }

    [Column("BAUD")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Baud { get; set; }

    [Column("PARITY")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Parity { get; set; }

    [Column("STOP_BITS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StopBits { get; set; }

    [Column("DATA_BITS")]
    [StringLength(5)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DataBits { get; set; }

    [Column("FLOW_CONTROL")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FlowControl { get; set; }

    [Column("INSTRUMENT_CLASS")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InstrumentClass { get; set; }

    [Column("LOW_THRESHOLD")]
    public virtual float? LowThreshold { get; set; }

    [Column("HIGH_THRESHOLD")]
    public virtual float? HighThreshold { get; set; }

    [Column("STABILITY_DELTA")]
    public virtual float? StabilityDelta { get; set; }

    [Column("STABILITY_NUMBER")]
    public virtual int? StabilityNumber { get; set; }

    [Column("PARENT_INSTRUMENT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParentInstrument { get; set; }

    [Column("INST_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InstTemplate { get; set; }

    [Column("CALIB_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CalibTemplate { get; set; }

    [Column("PM_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PmTemplate { get; set; }

    [Column("SERVICE_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ServiceTemplate { get; set; }

    [Column("NEEDS_CALIBRATION")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NeedsCalibration { get; set; }

    [Column("NEEDS_PM")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NeedsPm { get; set; }

    [Column("IP_ADDRESS")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string IpAddress { get; set; }

    [Column("PORT_NUMBER")]
    public virtual int? PortNumber { get; set; }

    [Column("TERM_PATTERN")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TermPattern { get; set; }

    [Column("TIME_OUT")]
    public virtual int? TimeOut { get; set; }

    [Column("XMIT_PREFIX")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string XmitPrefix { get; set; }

    [Column("XMIT_SUFFIX")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string XmitSuffix { get; set; }

    [Column("POLLING_TIME")]
    public virtual int? PollingTime { get; set; }

    [Column("COMM_PORT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CommPort { get; set; }

    [Column("HOLDS_SAMPLES")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string HoldsSamples { get; set; }

    [Column("DATA_PATH")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DataPath { get; set; }

    [Column("DISCARD_TIME")]
    public virtual int? DiscardTime { get; set; }

    [Column("FILTER_SCRIPT")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FilterScript { get; set; }

    [Column("PARSING_SCRIPT")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParsingScript { get; set; }

    [Column("POST_ARCHIVE_ACTION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PostArchiveAction { get; set; }

    [Column("SIZE_LIMIT")]
    public virtual int? SizeLimit { get; set; }

    [Column("SYNC_PATTERN")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SyncPattern { get; set; }

    [Column("RENAME_EXT")]
    [StringLength(3)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string RenameExt { get; set; }

    [Column("SOURCE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Source { get; set; }

    [Column("STEP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Step { get; set; }

    [Column("INCLUDE_SUBDIRS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string IncludeSubdirs { get; set; }

    [Column("FTP_USER")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FtpUser { get; set; }

    [Column("DEBUG")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Debug { get; set; }

    [Column("DIRECTORY")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Directory { get; set; }

    [Column("FTP_MODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FtpMode { get; set; }

    [Column("PASSWORD")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Password { get; set; }

    [Column("STORE_IN_DB_FILE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StoreInDbFile { get; set; }

    [Column("DB_FILE_PROMPT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DbFilePrompt { get; set; }
}