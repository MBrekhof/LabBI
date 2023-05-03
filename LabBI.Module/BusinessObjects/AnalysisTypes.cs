using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[DefaultClassOptions]
[NavigationItem("Analysis")]
[DefaultProperty("Name")]

[Table("ANALYSIS_TYPES")]
public   partial class AnalysisTypes :BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Description { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Removed { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string ExtLink { get; set; }
}