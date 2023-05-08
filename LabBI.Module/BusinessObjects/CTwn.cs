using DevExpress.Persistent.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("C_TWN")]
public partial class CTwn
{
    [Key]
    [Column("TAXON_NR")]
    public virtual int TaxonNr { get; set; }

    [Column("TAXON_TYPE")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxonType { get; set; }

    [Column("TAXONTYPE_NAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxontypeName { get; set; }

    [Column("TAXON_CODE")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxonCode { get; set; }

    [Column("TAXON_NAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxonName { get; set; }

    [Column("AUTHOR")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Author { get; set; }

    [Column("TAXON_GROUP")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxonGroup { get; set; }

    [Column("TAXONGROUP_NAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxongroupName { get; set; }

    [Column("TAXON_LEVEL")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TaxonLevel { get; set; }

    [Column("PARENT_NAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ParentName { get; set; }

    [Column("REFER_NAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReferName { get; set; }

    [Column("LITERATURE")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Literature { get; set; }

    [Column("LOCALNAME")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Localname { get; set; }

    [Column("DATE", TypeName = "date")]
    public virtual DateTime? Date { get; set; }

    [Column("STATUS")]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Status { get; set; }
}