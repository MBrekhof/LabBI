using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("BatchProtocol", "OrderNumber")]
[Table("BATCH_STANDARD")]
[DefaultClassOptions]
[NavigationItem("Batch")]
[DefaultProperty("BATCH_PROTOCOL")]
public partial class BatchStandard
{
    [Key]
    [Column("BATCH_PROTOCOL")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BatchProtocol { get; set; }

    [Key]
    [Column("ORDER_NUMBER")]
    public virtual int OrderNumber { get; set; }

    [Column("STANDARD")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Standard { get; set; }

    [Column("POSITION")]
    public virtual int? Position { get; set; }

    [Column("STARTING_POS")]
    public virtual int? StartingPos { get; set; }

    [Column("REPEAT_INTERVAL")]
    public virtual int? RepeatInterval { get; set; }

    [Column("REPEATING_STD")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string RepeatingStd { get; set; }

    [Column("STANDARD_REAGENT")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StandardReagent { get; set; }

    [Column("STANDARD_REAG_TMPL")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StandardReagTmpl { get; set; }

    [Column("CONCENTRATION")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Concentration { get; set; }
}