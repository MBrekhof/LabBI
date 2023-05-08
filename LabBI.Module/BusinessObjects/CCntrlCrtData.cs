﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_CNTRL_CRT_DATA")]
public partial class CCntrlCrtData
{
    [Key]
    [Column("ENTRY_CODE")]
    public int EntryCode { get; set; }

    [Column("CHART_NUM")]
    public int? ChartNum { get; set; }

    [Column("ORDER_NUMBER")]
    public int? OrderNumber { get; set; }

    [Column("DATE_ANALYSIS", TypeName = "datetime")]
    public DateTime? DateAnalysis { get; set; }

    [Column("OPERATOR")]
    [StringLength(20)]
    [Unicode(false)]
    public string Operator { get; set; }

    [Column("RESULT_VAL")]
    public float? ResultVal { get; set; }

    [Column("UNITS")]
    [StringLength(20)]
    [Unicode(false)]
    public string Units { get; set; }

    [Column("TEST_LOCATION")]
    [StringLength(20)]
    [Unicode(false)]
    public string TestLocation { get; set; }

    [Column("CURR_AVG")]
    public float? CurrAvg { get; set; }

    [Column("CURR_STD")]
    public float? CurrStd { get; set; }

    [Column("INCLUDED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Included { get; set; }

    [Column("RESULT_NUMBER")]
    public int? ResultNumber { get; set; }

    [Column("DEVIATION")]
    [StringLength(100)]
    [Unicode(false)]
    public string Deviation { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("INVESTIGATION")]
    [StringLength(50)]
    [Unicode(false)]
    public string Investigation { get; set; }

    [Column("C_CNTRL_CHART")]
    [StringLength(20)]
    [Unicode(false)]
    public string CCntrlChart { get; set; }

    [Column("REMARK")]
    [StringLength(254)]
    [Unicode(false)]
    public string Remark { get; set; }
}