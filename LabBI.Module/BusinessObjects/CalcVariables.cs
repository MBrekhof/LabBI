using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("Analysis", "Component", "Name", "Version")]
[Table("CALC_VARIABLES")]
//[Index("Name", Name = "CALC_VARIABLES2191")]
//[Index("Analysis", Name = "CALC_VARIABLES6558")]
//[Index("Component", Name = "CALC_VARIABLES9973")]
[DefaultClassOptions]
[NavigationItem("Samples")]
[DefaultProperty("Name")]
public  partial class CalcVariables: BaseObjectNoID
{
    [Key]
    [Column("ANALYSIS")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Analysis { get; set; }

    [Key]
    [Column("COMPONENT")]
    [StringLength(60)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Component { get; set; }

    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Key]
    [Column("VERSION")]
    public virtual int Version { get; set; }

    [Column("REFERENCE_TYPE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReferenceType { get; set; }

    [Column("REFERENCE_NAME")]
    [StringLength(40)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReferenceName { get; set; }

    [Column("ATTRIBUTE_1")]
    [StringLength(100)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Attribute1 { get; set; }

    [Column("RETURN_VALUE")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReturnValue { get; set; }

    [Column("SCOPE")]
    [StringLength(2)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Scope { get; set; }

    [Column("FUNCTION")]
    [StringLength(15)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Function { get; set; }

    [Column("RESULT_FIELD")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ResultField { get; set; }

    [Column("SPECIFIC_ANALYSIS")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string SpecificAnalysis { get; set; }

    [Column("ATTRIBUTE_2")]
    [StringLength(40)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Attribute2 { get; set; }

    [Column("CALC_TRIGGER")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CalcTrigger { get; set; }
}