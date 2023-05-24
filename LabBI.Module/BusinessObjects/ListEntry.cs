using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[PrimaryKey("List", "Name")]
[Table("LIST_ENTRY")]
//[Index("List", Name = "LIST_ENTRY_LIS8944")]
//[Index("Name", Name = "LIST_ENTRY_NA14797")]
[DefaultClassOptions]
[NavigationItem("Lists")]
[DefaultProperty("Name")]
public  partial class ListEntry: BaseObjectNoID
{
    [Key]
    [Column("LIST")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string List { get; set; }

    [Key]
    [Column("NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Name { get; set; }

    [Column("VALUE")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Value { get; set; }

    [Column("ORDER_NUMBER")]
    public virtual int? OrderNumber { get; set; }
}