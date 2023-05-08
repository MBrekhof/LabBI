using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_RESULT_SPEC")]
//[Index("ResultNumber", "SpecSeqNum", Name = "idx_CRESULTSPEC", IsUnique = true)]
public partial class CResultSpec
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("RESULT_NUMBER")]
    public virtual int ResultNumber { get; set; }

    [Column("SPEC_SEQ_NUM")]
    public virtual int SpecSeqNum { get; set; }

    [Column("RESULT_VALUE")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ResultValue { get; set; }

    [Column("IN_SPEC")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string InSpec { get; set; }

    [Column("SPEC_CODE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecCode { get; set; }
}