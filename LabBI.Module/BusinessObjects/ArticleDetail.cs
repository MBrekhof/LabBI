
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;
[DefaultClassOptions]
[NavigationItem("LabwareAI")]

public partial class ArticleDetail:BaseObjectNoID
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual int ArticleDetailId { get; set; }

    public virtual int ArticleId { get; set; }

    public virtual int ArticleSequence { get; set; }

    public virtual string ArticleContent { get; set; }

    [ForeignKey("ArticleId")]
    [InverseProperty("ArticleDetail")]
    public virtual Article Article { get; set; }

    [InverseProperty("ArticleDetail")]
    public virtual ICollection<ArticleVectorData> ArticleVectorData { get; set; } = new ObservableCollection<ArticleVectorData>();
}