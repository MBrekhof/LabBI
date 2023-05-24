using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabBI.Module.BusinessObjects;

[Table("PERSON")]
//[Index("AddressBook", Name = "PERSON_ADDRESS7446")]
//[Index("Organization", Name = "idxPersonOrganization")]
[DefaultClassOptions]
[NavigationItem("CRM")]
[DefaultProperty("LastName")]
public  partial class Person: BaseObjectNoID
{
    [Key]
    [Column("PERSON_NUMBER")]
    public virtual int PersonNumber { get; set; }

    [Column("ADDRESS_BOOK")]
    [StringLength(20)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string AddressBook { get; set; }

    [Column("REMOVED")]
    [StringLength(1)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Removed { get; set; }

    [Column("ALIAS")]
    [StringLength(30)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Alias { get; set; }

    [Column("SALUTATION")]
    [StringLength(5)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Salutation { get; set; }

    [Column("FIRST_NAME")]
    [StringLength(20)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string FirstName { get; set; }

    [Column("MID_INIT")]
    [StringLength(5)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string MidInit { get; set; }

    [Column("LAST_NAME")]
    [StringLength(30)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string LastName { get; set; }

    [Column("NAME_SUFX")]
    [StringLength(5)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string NameSufx { get; set; }

    [Column("TITLE")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Title { get; set; }

    [Column("ORGANIZATION")]
    [StringLength(40)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string Organization { get; set; }

    [Column("STREET_ADDR")]
    [StringLength(100)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string StreetAddr { get; set; }

    [Column("CITY")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string City { get; set; }

    [Column("STATE")]
    [StringLength(50)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string State { get; set; }

    [Column("COUNTRY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Country { get; set; }

    [Column("ZIP")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Zip { get; set; }

    [Column("TEL_COUNTRY_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TelCountryCode { get; set; }

    [Column("TEL_AREA_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TelAreaCode { get; set; }

    [Column("PHONE")]
    [StringLength(20)]
        [VisibleInListView(true), VisibleInLookupListView(true)]
    public virtual string Phone { get; set; }

    [Column("EXTENSION")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string Extension { get; set; }

    [Column("CELL_AREA_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CellAreaCode { get; set; }

    [Column("CELL_NUMBER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CellNumber { get; set; }

    [Column("FAX_AREA_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FaxAreaCode { get; set; }

    [Column("FAX_NUMBER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FaxNumber { get; set; }

    [Column("FAX_EXTENSION")]
    [StringLength(10)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FaxExtension { get; set; }

    [Column("BEEPER_AREA_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BeeperAreaCode { get; set; }

    [Column("BEEPER_NUMBER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BeeperNumber { get; set; }

    [Column("HOME_AREA_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string HomeAreaCode { get; set; }

    [Column("HOME_NUMBER")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string HomeNumber { get; set; }

    [Column("EMAIL_ADDR")]
    [StringLength(100)]
        [VisibleInListView(true), VisibleInLookupListView(false)]
    public virtual string EmailAddr { get; set; }

    [Column("PERSON_NOTE")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string PersonNote { get; set; }

    [Column("EXT_LINK")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ExtLink { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string GroupName { get; set; }

    [Column("CHANGED_BY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ChangedBy { get; set; }

    [Column("CHANGED_ON", TypeName = "datetime")]
    public virtual DateTime? ChangedOn { get; set; }

    [Column("FULL_NAME")]
    [StringLength(60)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FullName { get; set; }

    [Column("RELATES_TO")]
    public virtual int? RelatesTo { get; set; }

    [Column("CONTACT_TYPE")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string ContactType { get; set; }

    [Column("FAX_COUNTRY_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string FaxCountryCode { get; set; }

    [Column("BEEPER_COUNTRY_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string BeeperCountryCode { get; set; }

    [Column("CELL_COUNTRY_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string CellCountryCode { get; set; }

    [Column("HOME_COUNTRY_CODE")]
    [StringLength(4)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string HomeCountryCode { get; set; }

    [Column("RECORD_SET")]
    [StringLength(254)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string RecordSet { get; set; }

    [Column("T_INVOICE_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoiceDelivery { get; set; }

    [Column("T_INVOICE_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TInvoicePrimary { get; set; }

    [Column("T_REPORT_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReportDelivery { get; set; }

    [Column("T_REPORT_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReportPrimary { get; set; }

    [Column("T_RECEIPT_DELIVERY")]
    [StringLength(20)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReceiptDelivery { get; set; }

    [Column("T_RECEIPT_PRIMARY")]
    [StringLength(1)]
        [VisibleInListView(false), VisibleInLookupListView(false)]
    public virtual string TReceiptPrimary { get; set; }
}