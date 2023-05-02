﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[Table("T_COA_TEMPLATE")]
public partial class TCoaTemplate
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Removed { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [Unicode(false)]
    public string ExtLink { get; set; }

    [Column("QUERY_TAG")]
    [StringLength(50)]
    [Unicode(false)]
    public string QueryTag { get; set; }

    [Column("CROSSTAB_REPORT")]
    [StringLength(1)]
    [Unicode(false)]
    public string CrosstabReport { get; set; }

    [Column("RUN_REPORT_SUB")]
    [StringLength(50)]
    [Unicode(false)]
    public string RunReportSub { get; set; }

    [Column("MAIN_CROSSTAB")]
    [StringLength(20)]
    [Unicode(false)]
    public string MainCrosstab { get; set; }

    [Column("NUMBER_OF_COLUMNS")]
    public int? NumberOfColumns { get; set; }

    [Column("QC_CROSSTAB")]
    [StringLength(20)]
    [Unicode(false)]
    public string QcCrosstab { get; set; }

    [Column("QC_SAMPLE_TYPES")]
    [StringLength(255)]
    [Unicode(false)]
    public string QcSampleTypes { get; set; }

    [Column("INCLUDE_ALL_QC_COMPS")]
    [StringLength(1)]
    [Unicode(false)]
    public string IncludeAllQcComps { get; set; }

    [Column("REPORT_QC_CALC_DATA")]
    [StringLength(1)]
    [Unicode(false)]
    public string ReportQcCalcData { get; set; }

    [Column("REPORT_GROUP")]
    [StringLength(20)]
    [Unicode(false)]
    public string ReportGroup { get; set; }

    [Column("REPORT_GROUP_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ReportGroupBy { get; set; }
}