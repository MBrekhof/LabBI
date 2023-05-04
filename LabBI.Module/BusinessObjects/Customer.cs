using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("CUSTOMER")]
//[Index("CompanyName", Name = "idxCustomerCompany")]
[DefaultClassOptions]
[NavigationItem("CRM")]
[DefaultProperty("NAME")]
public partial class Customer : BaseObjectNoID
{
    [Key]
    [Column("NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Name { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string GroupName { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Description { get; set; }

    [Column("COMPANY_NAME")]
    [StringLength(80)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string CompanyName { get; set; }

    [Column("ADDRESS1")]
    [StringLength(78)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Address1 { get; set; }

    [Column("ADDRESS2")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address2 { get; set; }

    [Column("ADDRESS3")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address3 { get; set; }

    [Column("ADDRESS4")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address4 { get; set; }

    [Column("ADDRESS5")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address5 { get; set; }

    [Column("ADDRESS6")]
    [StringLength(78)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Address6 { get; set; }

    [Column("FAX_NUM")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FaxNum { get; set; }

    [Column("PHONE_NUM")]
    [StringLength(20)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string PhoneNum { get; set; }

    [Column("CONTACT")]
    [StringLength(78)]
    [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Contact { get; set; }

    [Column("COST_FACTOR")]
    public virtual float? CostFactor { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("REPORT_FORMAT")]
    [StringLength(50)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ReportFormat { get; set; }

    [Column("EMAIL_ADDR")]
    [StringLength(150)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string EmailAddr { get; set; }

    [Column("RECORD_SET")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string RecordSet { get; set; }

    [Column("T_BAD_DEBT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TBadDebt { get; set; }

    [Column("T_CERT_FORMATS")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCertFormats { get; set; }

    [Column("T_COA_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCoaTemplate { get; set; }

    [Column("T_COVER_LETTER")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCoverLetter { get; set; }

    [Column("T_CUSTOMER_GROUP")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TCustomerGroup { get; set; }

    [Column("T_EMAIL")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TEmail { get; set; }

    [Column("T_PO_REQUIRED")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPoRequired { get; set; }

    [Column("T_PREPAY")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrepay { get; set; }

    [Column("T_PRINT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TPrint { get; set; }

    [Column("T_PROSPECT")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TProspect { get; set; }

    [Column("T_REPORT_TO")]
    public virtual int? TReportTo { get; set; }

    [Column("T_TEST_LIST")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TTestList { get; set; }

    [Column("T_VIEW_GROUP_DATA")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TViewGroupData { get; set; }

    [Column("T_WEB")]
    [StringLength(1)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TWeb { get; set; }

    [Column("T_WEB_FOLDER")]
    [StringLength(255)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TWebFolder { get; set; }

    [Column("T_RECEIPT_TEMPLATE")]
    [StringLength(20)]
    [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReceiptTemplate { get; set; }
    public virtual IList<Invoice> Invoices { get; set; } = new ObservableCollection<Invoice>();
}