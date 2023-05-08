﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_TRANSITION")]
public partial class CTransition
{
    [Key]
    [Column("TRANS_NR")]
    public int TransNr { get; set; }

    [Column("SAMPLE_TYPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string SampleType { get; set; }

    [Column("COMP_NAME")]
    [StringLength(60)]
    [Unicode(false)]
    public string CompName { get; set; }

    [Column("ANALYSIS")]
    [StringLength(20)]
    public string Analysis { get; set; }

    [Column("SPEC_CODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string SpecCode { get; set; }

    [Column("TRANS_COMP_NAM")]
    [StringLength(60)]
    public string TransCompNam { get; set; }

    [Column("TRANS_ANALYSIS")]
    [StringLength(20)]
    public string TransAnalysis { get; set; }

    [Column("NUM_REPLICATES")]
    public int? NumReplicates { get; set; }

    [Column("CREATED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_ON", TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [Column("CHANCHED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChanchedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }
}