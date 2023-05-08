﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_DISCLAIMER_CAT")]
public partial class CDisclaimerCat
{
    [Key]
    [Column("CATEGORY")]
    [StringLength(20)]
    public string Category { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Removed { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }
}