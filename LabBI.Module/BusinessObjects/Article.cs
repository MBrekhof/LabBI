
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using Microsoft.EntityFrameworkCore;

namespace LabBI.Module.BusinessObjects;
[DefaultClassOptions]
[NavigationItem("LabwareAI")]
[DefaultProperty("ArticleName")]
public partial class Article:BaseObjectNoID
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual int ArticleId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public virtual string ArticleName { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public virtual string Description { get; set; }

    [InverseProperty("Article")]
    public virtual ICollection<ArticleDetail> ArticleDetail { get; set; } = new List<ArticleDetail>();
}