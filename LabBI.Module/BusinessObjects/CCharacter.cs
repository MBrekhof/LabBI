using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_CHARACTER")]
//[Index("Code", Name = "idxCharacterCode")]
public partial class CCharacter
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Column("CUSTOMER")]
    [StringLength(20)]
    public virtual string Customer { get; set; }

    [Required]
    [Column("OBJECT_CLASS")]
    [StringLength(50)]
    public virtual string ObjectClass { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual short? OrderNumber { get; set; }

    [Required]
    [Column("CODE")]
    [StringLength(4)]
    public virtual string Code { get; set; }

    [Required]
    [Column("DESCRIPTION")]
    [StringLength(50)]
    public virtual string Description { get; set; }

    [Column("PRINTEN")]
    public virtual short? Printen { get; set; }

    [Column("TYPE")]
    [StringLength(15)]
    public virtual string Type { get; set; }

    [Column("DEFINITION")]
    [StringLength(60)]
    public virtual string Definition { get; set; }

    [Column("KM_REQ")]
    [StringLength(1)]
    public virtual string KmReq { get; set; }

    [Column("ACTIVE")]
    [StringLength(1)]
    public virtual string Active { get; set; }

    [Column("REFERENCE")]
    [StringLength(1)]
    public virtual string Reference { get; set; }

    [Column("MIN")]
    [StringLength(60)]
    public virtual string Min { get; set; }

    [Column("MAX")]
    [StringLength(60)]
    public virtual string Max { get; set; }

    [Column("CTYPE")]
    [StringLength(8)]
    public virtual string Ctype { get; set; }

    [Column("COLNAME")]
    [StringLength(18)]
    public virtual string Colname { get; set; }

    [Column("OPM_NR")]
    public virtual int? OpmNr { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    public virtual string CreatedBy { get; set; }

    [Column("CREATED_ON", TypeName = "datetime")]
    public virtual DateTime? CreatedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }
}