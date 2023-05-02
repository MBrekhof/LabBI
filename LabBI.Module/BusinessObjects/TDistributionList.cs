﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[Table("T_DISTRIBUTION_LIST")]
[Index("Customer", Name = "T_DISTRIBUTIO13851")]
public partial class TDistributionList
{
    [Key]
    [Column("NAME")]
    [StringLength(50)]
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

    [Column("CUSTOMER")]
    [StringLength(20)]
    [Unicode(false)]
    public string Customer { get; set; }

    [Column("ALL_PROJECTS")]
    [StringLength(1)]
    [Unicode(false)]
    public string AllProjects { get; set; }

    [Column("RECORD_SET")]
    [StringLength(254)]
    [Unicode(false)]
    public string RecordSet { get; set; }
}