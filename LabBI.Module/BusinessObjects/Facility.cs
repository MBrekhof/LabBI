﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("FACILITY")]
public partial class Facility
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [Unicode(false)]
    public string Removed { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string GroupName { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [Unicode(false)]
    public string ExtLink { get; set; }

    [Column("PARENT_FACILITY")]
    [StringLength(20)]
    [Unicode(false)]
    public string ParentFacility { get; set; }

    [Column("ADDRESS1")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address1 { get; set; }

    [Column("ADDRESS2")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address2 { get; set; }

    [Column("ADDRESS3")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address3 { get; set; }

    [Column("ADDRESS4")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address4 { get; set; }

    [Column("ADDRESS5")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address5 { get; set; }

    [Column("ADDRESS6")]
    [StringLength(254)]
    [Unicode(false)]
    public string Address6 { get; set; }

    [Column("FACILITY_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string FacilityType { get; set; }

    [Column("LAB_GROUP")]
    [StringLength(20)]
    [Unicode(false)]
    public string LabGroup { get; set; }

    [Column("T_OUTSIDE")]
    [StringLength(1)]
    [Unicode(false)]
    public string TOutside { get; set; }

    [Column("T_ALL_COMP_ACCRED")]
    [StringLength(1)]
    [Unicode(false)]
    public string TAllCompAccred { get; set; }

    [Column("T_CERTIFICATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string TCertification { get; set; }

    [Column("T_SHIP_REQUEST_EMAIL")]
    [StringLength(255)]
    [Unicode(false)]
    public string TShipRequestEmail { get; set; }

    [Column("T_PHONE")]
    [StringLength(20)]
    [Unicode(false)]
    public string TPhone { get; set; }
}