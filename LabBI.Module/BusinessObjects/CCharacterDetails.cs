using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_CHARACTER_DETAILS")]
//[Index("CCharacter", Name = "idxCDetailsCharacter")]
//[Index("ObjectClass", "ObjectItem", Name = "idxObject-Class-Item-CCharDetails")]
public partial class CCharacterDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public virtual int SeqNum { get; set; }

    [Required]
    [Column("OBJECT_CLASS")]
    [StringLength(50)]
    public virtual string ObjectClass { get; set; }

    [Column("OBJECT_ITEM")]
    [StringLength(50)]
    public virtual string ObjectItem { get; set; }

    [Column("KEYN")]
    public virtual int? Keyn { get; set; }

    [Column("C_CHARACTER")]
    public virtual int CCharacter { get; set; }

    [Column("VALUE")]
    [StringLength(60)]
    public virtual string Value { get; set; }

    [Column("REPORTABLE")]
    public virtual short? Reportable { get; set; }

    [Column("KM_ST")]
    public virtual short? KmSt { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    public virtual string CreatedBy { get; set; }

    [Column("CREATED_ON", TypeName = "datetime")]
    public virtual DateTime? CreatedOn { get; set; }
}