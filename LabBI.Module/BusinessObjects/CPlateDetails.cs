using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace LabBI.Module.BusinessObjects;
[DefaultClassOptions]
[NavigationItem("Platen")]
[DefaultProperty("Header")]
[Table("C_PLATE_DETAILS")]
public partial class CPlateDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }
    public virtual string Header
    {
        get { return Analysis + " " + PlateCode + " " + (Volume.HasValue ? Volume.Value.ToString("F2"):"") ; }
    }


    [Required]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Analysis { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(8)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Type { get; set; }

    [Column("GROUP_NUMBER")]
    public virtual int? GroupNumber { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }

    [Column("VOLUME", TypeName = "decimal(16, 8)")]
    public virtual decimal? Volume { get; set; }

    [Column("PLATE_CODE")]
    [StringLength(10)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PlateCode { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public virtual DateTime? DateCreated { get; set; }
}