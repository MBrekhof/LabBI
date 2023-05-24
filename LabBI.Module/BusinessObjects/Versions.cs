using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LabBI.Module.BusinessObjects;

[PrimaryKey("TableName", "Name")]
[Table("VERSIONS")]
//[Index("Name", Name = "VERSIONS_NAME8197")]
//[Index("TableName", Name = "VERSIONS_TABLE6472")]
[DefaultClassOptions]
[NavigationItem("Overig")]
[DefaultProperty("Name")]
public  partial class Versions: BaseObjectNoID
{
    [Key]
    [Column("TABLE_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TableName { get; set; }

    [Key]
    [Column("NAME")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("VERSION")]
    public virtual int? Version { get; set; }
}