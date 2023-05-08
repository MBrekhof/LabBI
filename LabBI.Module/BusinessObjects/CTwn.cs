﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;

[Table("C_TWN")]
public partial class CTwn
{
    [Key]
    [Column("TAXON_NR")]
    public int TaxonNr { get; set; }

    [Column("TAXON_TYPE")]
    [Unicode(false)]
    public string TaxonType { get; set; }

    [Column("TAXONTYPE_NAME")]
    [Unicode(false)]
    public string TaxontypeName { get; set; }

    [Column("TAXON_CODE")]
    [Unicode(false)]
    public string TaxonCode { get; set; }

    [Column("TAXON_NAME")]
    [Unicode(false)]
    public string TaxonName { get; set; }

    [Column("AUTHOR")]
    [Unicode(false)]
    public string Author { get; set; }

    [Column("TAXON_GROUP")]
    [Unicode(false)]
    public string TaxonGroup { get; set; }

    [Column("TAXONGROUP_NAME")]
    [Unicode(false)]
    public string TaxongroupName { get; set; }

    [Column("TAXON_LEVEL")]
    [Unicode(false)]
    public string TaxonLevel { get; set; }

    [Column("PARENT_NAME")]
    [Unicode(false)]
    public string ParentName { get; set; }

    [Column("REFER_NAME")]
    [Unicode(false)]
    public string ReferName { get; set; }

    [Column("LITERATURE")]
    [Unicode(false)]
    public string Literature { get; set; }

    [Column("LOCALNAME")]
    [Unicode(false)]
    public string Localname { get; set; }

    [Column("DATE", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("STATUS")]
    [Unicode(false)]
    public string Status { get; set; }
}