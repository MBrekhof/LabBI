﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_CHARACTER_DETAILS")]
[Index("CCharacter", Name = "idxCDetailsCharacter")]
[Index("ObjectClass", "ObjectItem", Name = "idxObject-Class-Item-CCharDetails")]
public partial class CCharacterDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public int SeqNum { get; set; }

    [Required]
    [Column("OBJECT_CLASS")]
    [StringLength(50)]
    public string ObjectClass { get; set; }

    [Column("OBJECT_ITEM")]
    [StringLength(50)]
    public string ObjectItem { get; set; }

    [Column("KEYN")]
    public int? Keyn { get; set; }

    [Column("C_CHARACTER")]
    public int CCharacter { get; set; }

    [Column("VALUE")]
    [StringLength(60)]
    public string Value { get; set; }

    [Column("REPORTABLE")]
    public short? Reportable { get; set; }

    [Column("KM_ST")]
    public short? KmSt { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    public string CreatedBy { get; set; }

    [Column("CREATED_ON")]
    public DateTime? CreatedOn { get; set; }
}