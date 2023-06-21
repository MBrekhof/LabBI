using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;
[DefaultClassOptions]
[NavigationItem("Platen")]
//[DefaultProperty("AccountNumber")]
[Table("C_SCAN_DETAILS")]
//[Index("SampleNumber", "PlateDetails", Name = "idxSCAN_DETAILS_SAMPLENO")]
public partial class CScanDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("SAMPLE_NUMBER")]
    public virtual int SampleNumber { get; set; }

    [Column("PLATE_DETAILS")]
    [VisibleInListView(false), VisibleInLookupListView(false), VisibleInDetailView(false)]
    public virtual int? PlateDetailsID { get; set; }
    public virtual CPlateDetails PlateDetails { get; set; }

    [Required]
    [Column("BARCODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Barcode { get; set; }

    [Column("DUPLO")]
    [StringLength(2)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Duplo { get; set; }

    [Column("SCAN_DATETIME", TypeName = "datetime")]
    public virtual DateTime? ScanDatetime { get; set; }

    [Column("ENTRY")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Entry { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public virtual DateTime? DateCreated { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("PRINTED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Printed { get; set; }

    [Column("TEST_NUMBER")]
    public virtual int? TestNumber { get; set; }
}