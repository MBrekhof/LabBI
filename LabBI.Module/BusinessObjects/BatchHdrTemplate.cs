using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("Name", "Version")]
[Table("BATCH_HDR_TEMPLATE")]
//[Index("AnalysisLinkKey", Name = "BATCH_HDR_TEM13802")]
//[Index("ChangeLinkKey", Name = "BATCH_HDR_TEMP5792")]
[DefaultClassOptions]
[NavigationItem("Batch")]
[DefaultProperty("NAME")]
public partial class BatchHdrTemplate
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Key]
    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("NAME_PREFIX")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NamePrefix { get; set; }

    [Column("ID_CONFIG")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string IdConfig { get; set; }

    [Column("GLOBAL_FLAG")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GlobalFlag { get; set; }

    [Column("BATCH_PROTOCOL")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchProtocol { get; set; }

    [Column("ASSIGN_TO_OBJECTS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AssignToObjects { get; set; }

    [Column("ANALYSIS_LINK_FIELD")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AnalysisLinkField { get; set; }

    [Column("ANALYSIS_LINK_KEY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AnalysisLinkKey { get; set; }

    [Column("CHANGE_LINK_KEY")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangeLinkKey { get; set; }

    [Column("FOLDER_TAG")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FolderTag { get; set; }

    [Column("REQUIRED_NUM")]
    public virtual int? RequiredNum { get; set; }

    [Column("MAXIMUM_NUM")]
    public virtual int? MaximumNum { get; set; }

    [Column("REFRESH_INTERVAL")]
    public virtual int? RefreshInterval { get; set; }

    [Column("ADD_IF_BATCHED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AddIfBatched { get; set; }

    [Column("BATCH_REPORT")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchReport { get; set; }

    [Column("OBJECT_CLASS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ObjectClass { get; set; }

    [Column("SCAN_FIELD")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ScanField { get; set; }

    [Column("BATCH_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchType { get; set; }

    [Column("EDIT_TEST_TEMP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EditTestTemp { get; set; }

    [Column("EDIT_SAMPLE_TEMP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EditSampleTemp { get; set; }

    [Column("CHART_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChartGroup { get; set; }

    [Column("C_BATCH_PROTOCOL")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CBatchProtocol { get; set; }

    [Column("FILE_EXPORT_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FileExportType { get; set; }
}