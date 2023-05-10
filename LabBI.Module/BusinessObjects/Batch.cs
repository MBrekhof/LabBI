using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LabBI.Module.BusinessObjects;

[Table("BATCH")]
//[Index("AnalysisLinkKey", Name = "BATCH_ANALYSIS8822")]
//[Index("ChangeLinkKey", Name = "BATCH_CHANGE_L3652")]
[DefaultClassOptions]
[NavigationItem("Batch")]
[DefaultProperty("Name")]
public  partial class Batch : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual  string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("OBJECT_CLASS")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ObjectClass { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GLOBAL_FLAG")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GlobalFlag { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Template { get; set; }

    [Column("NOTE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Note { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CreatedBy { get; set; }

    [Column("DATE_CREATED", TypeName = "datetime")]
    public virtual DateTime? DateCreated { get; set; }

    [Column("BATCH_COMMENT")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchComment { get; set; }

    [Column("OWNER")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Owner { get; set; }

    [Column("TEMPLATE_VERSION")]
    public virtual int? TemplateVersion { get; set; }

    [Column("INSTRUMENT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Instrument { get; set; }

    [Column("BATCH_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchType { get; set; }

    [Column("BATCH_STATUS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchStatus { get; set; }

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

    [Column("CLOSED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Closed { get; set; }

    [Column("REFRESH_INTERVAL")]
    public virtual int? RefreshInterval { get; set; }

    [Column("VARIATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Variation { get; set; }

    [Column("SIGNED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Signed { get; set; }

    [Column("INVESTIGATED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Investigated { get; set; }

    [Column("C_BATCH_DEPLOYED")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CBatchDeployed { get; set; }

    [Column("C_FACILITY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CFacility { get; set; }
}