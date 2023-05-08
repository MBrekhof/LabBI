using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;



[PrimaryKey("Template", "FieldName", "Version")]
[Table("BATCH_HDR_TMP_FLDS")]
[DefaultClassOptions]
[NavigationItem("Batch")]
[DefaultProperty("TEMPLATE")]
public partial class BatchHdrTmpFlds
{
    [Key]
    [Column("TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Template { get; set; }

    [Key]
    [Column("FIELD_NAME")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FieldName { get; set; }

    [Column("ENTRY_MODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EntryMode { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("DEFAULT_VALUE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DefaultValue { get; set; }

    [Column("FIELD_LABEL")]
    [StringLength(30)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FieldLabel { get; set; }

    [Column("FORMULA", TypeName = "text")]
    public virtual string Formula { get; set; }

    [Column("ALLOW_USER_ENTRY")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string AllowUserEntry { get; set; }

    [Key]
    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("DATA_TYPE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DataType { get; set; }

    [Column("DEPENDS_ON")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string DependsOn { get; set; }
}