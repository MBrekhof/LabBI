﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_SPEC_CODE")]
public partial class CSpecCode
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(256)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("NOTIFICATION")]
    [StringLength(256)]
    [Unicode(false)]
    public string Notification { get; set; }
}