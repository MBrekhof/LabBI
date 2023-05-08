﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[PrimaryKey("UserName", "Instrument")]
[Table("INSTRUMENT_APPROVAL")]
[Index("UserName", Name = "INSTRUMENT_AP13995")]
[Index("Instrument", Name = "INSTRUMENT_APP1413")]
public partial class InstrumentApproval
{
    [Key]
    [Column("USER_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Key]
    [Column("INSTRUMENT")]
    [StringLength(20)]
    [Unicode(false)]
    public string Instrument { get; set; }

    [Column("APPROVAL_DATE", TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [Column("APPROVAL_INTV")]
    public int? ApprovalIntv { get; set; }

    [Column("APPROVER")]
    [StringLength(1)]
    [Unicode(false)]
    public string Approver { get; set; }

    [Column("EXPIRATION_DATE", TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [Column("EXPIRED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Expired { get; set; }
}