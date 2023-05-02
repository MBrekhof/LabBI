﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[Table("COST_ITEM")]
public partial class CostItem
{
    [Key]
    [Column("COST_ITEM_NO")]
    public int CostItemNo { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(30)]
    [Unicode(false)]
    public string ItemCode { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    public string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string GroupName { get; set; }

    [Column("BASE_CURRENCY")]
    [StringLength(20)]
    [Unicode(false)]
    public string BaseCurrency { get; set; }

    [Column("BASE_COST")]
    [StringLength(10)]
    [Unicode(false)]
    public string BaseCost { get; set; }

    [Column("PERCENT_MARGIN")]
    [StringLength(10)]
    [Unicode(false)]
    public string PercentMargin { get; set; }

    [Column("LIST_PRICE")]
    [StringLength(10)]
    [Unicode(false)]
    public string ListPrice { get; set; }

    [Column("OBJECT_TABLE")]
    [StringLength(20)]
    [Unicode(false)]
    public string ObjectTable { get; set; }

    [Column("OBJECT_KEY")]
    [StringLength(50)]
    [Unicode(false)]
    public string ObjectKey { get; set; }

    [Column("OBJECT_TABLE_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string ObjectTable2 { get; set; }

    [Column("OBJECT_KEY_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string ObjectKey2 { get; set; }

    [Column("EXT_LINK")]
    [StringLength(255)]
    [Unicode(false)]
    public string ExtLink { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Removed { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    [Unicode(false)]
    public string ActiveFlag { get; set; }

    [Column("DISCOUNTABLE")]
    [StringLength(1)]
    [Unicode(false)]
    public string Discountable { get; set; }

    [Column("T_ANALYSIS_TYPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string TAnalysisType { get; set; }

    [Column("T_COMMON_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string TCommonName { get; set; }

    [Column("NUM_RESULTS")]
    public int? NumResults { get; set; }

    [Column("XTRA_RSLT_COST_ITM")]
    [StringLength(20)]
    [Unicode(false)]
    public string XtraRsltCostItm { get; set; }

    [Column("BASE_ITEM")]
    [StringLength(1)]
    [Unicode(false)]
    public string BaseItem { get; set; }

    [Column("ALL_RSLTS_SAME_PRICE")]
    [StringLength(1)]
    [Unicode(false)]
    public string AllRsltsSamePrice { get; set; }

    [Column("ASSOCIATED_COST_ITEM")]
    public int? AssociatedCostItem { get; set; }
}