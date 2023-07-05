
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using Microsoft.EntityFrameworkCore;

// https://github.com/DevExpress-Examples/XAF_how-to-store-file-attachments-in-the-file-system-instead-of-the-database

namespace LabBI.Module.BusinessObjects;
[DefaultClassOptions]
[NavigationItem("LabwareAI")]
[DefaultProperty("ArticleName")]
[FileAttachmentAttribute(nameof(File))]
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


    [ExpandObjectMembers(ExpandObjectMembers.Never)]
    [FileTypeFilter("DocumentFiles", 1, "*.txt", "*.doc")]
    [FileTypeFilter("AllFiles", 2, "*.*")]
    public virtual FileData File { get; set; }

    [InverseProperty("Article")]
    public virtual ICollection<ArticleDetail> ArticleDetail { get; set; } = new ObservableCollection<ArticleDetail>();
}