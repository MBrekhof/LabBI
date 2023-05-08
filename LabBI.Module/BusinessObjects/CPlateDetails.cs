﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_PLATE_DETAILS")]
public partial class CPlateDetails
{
    [Key]
    [Column("SEQ_NUM")]
    public int SeqNum { get; set; }

    [Required]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [Unicode(false)]
    public string Analysis { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(8)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("GROUP_NUMBER")]
    public int? GroupNumber { get; set; }

    [Column("ORDER_NUMBER")]
    public int? OrderNumber { get; set; }

    [Column("VOLUME", TypeName = "decimal(16, 8)")]
    public decimal? Volume { get; set; }

    [Column("PLATE_CODE")]
    [StringLength(10)]
    [Unicode(false)]
    public string PlateCode { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("DATE_CREATED", TypeName = "date")]
    public DateTime? DateCreated { get; set; }
}