﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects.BusinessObjects;

[Table("LOCATION")]
public partial class Location
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

    [Column("ADDRESS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Address { get; set; }

    [Column("ZIP")]
    [StringLength(9)]
    [Unicode(false)]
    public string Zip { get; set; }

    [Column("CONTACT")]
    [StringLength(78)]
    [Unicode(false)]
    public string Contact { get; set; }

    [Column("PHONE")]
    [StringLength(30)]
    [Unicode(false)]
    public string Phone { get; set; }

    [Column("FAX")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fax { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [Unicode(false)]
    public string GroupName { get; set; }

    [Column("OUTSIDE")]
    [StringLength(1)]
    [Unicode(false)]
    public string Outside { get; set; }

    [Column("COMPANY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Company { get; set; }

    [Column("SITE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Site { get; set; }

    [Column("BUILDING")]
    [StringLength(50)]
    [Unicode(false)]
    public string Building { get; set; }

    [Column("ROOM_NUMBER")]
    [StringLength(20)]
    [Unicode(false)]
    public string RoomNumber { get; set; }

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

    [Column("EXT_LINK")]
    [StringLength(254)]
    [Unicode(false)]
    public string ExtLink { get; set; }

    [Column("FACILITY")]
    [StringLength(20)]
    [Unicode(false)]
    public string Facility { get; set; }

    [Column("LOCATION_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationType { get; set; }

    [Column("C_CITY")]
    [StringLength(80)]
    [Unicode(false)]
    public string CCity { get; set; }
}