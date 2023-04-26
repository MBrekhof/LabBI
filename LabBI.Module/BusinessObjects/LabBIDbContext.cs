using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DevExpress.Persistent.BaseImpl.EFCore.AuditTrail;
using DevExpress.Persistent.BaseImpl.EF.Kpi;


namespace LabBI.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class LabBIContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<LabBIEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new LabBIEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class LabBIDesignTimeDbContextFactory : IDesignTimeDbContextFactory<LabBIEFCoreDbContext> {
	public LabBIEFCoreDbContext CreateDbContext(string[] args) {
		//throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		var optionsBuilder = new DbContextOptionsBuilder<LabBIEFCoreDbContext>();
		optionsBuilder.UseSqlServer("Encrypt=false;Integrated Security=SSPI;Data Source=BCH-BTO;Initial Catalog=Labware8Migrate");
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
		return new LabBIEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(LabBIContextInitializer))]
public class LabBIEFCoreDbContext : DbContext {
	public LabBIEFCoreDbContext(DbContextOptions<LabBIEFCoreDbContext> options) : base(options) {
	}
	//public DbSet<ModuleInfo> ModulesInfo { get; set; }
	public DbSet<ModelDifference> ModelDifferences { get; set; }
	public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	public DbSet<PermissionPolicyRole> Roles { get; set; }
	public DbSet<LabBI.Module.BusinessObjects.ApplicationUser> Users { get; set; }
    public DbSet<LabBI.Module.BusinessObjects.ApplicationUserLoginInfo> UserLoginInfos { get; set; }
	public DbSet<FileData> FileData { get; set; }
	public DbSet<ReportDataV2> ReportDataV2 { get; set; }
	public DbSet<KpiDefinition> KpiDefinition { get; set; }
	public DbSet<KpiInstance> KpiInstance { get; set; }
	public DbSet<KpiHistoryItem> KpiHistoryItem { get; set; }
	public DbSet<KpiScorecard> KpiScorecard { get; set; }
	public DbSet<DashboardData> DashboardData { get; set; }
    public DbSet<AuditDataItemPersistent> AuditData { get; set; }
    public DbSet<AuditEFCoreWeakReference> AuditEFCoreWeakReference { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<Invoice> Invoice { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.Entity<LabBI.Module.BusinessObjects.ApplicationUserLoginInfo>(b => {
            b.HasIndex(nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.LoginProviderName), nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.ProviderUserKey)).IsUnique();
        });
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.AuditItems)
            .WithOne(p => p.AuditedObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.OldItems)
            .WithOne(p => p.OldObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.NewItems)
            .WithOne(p => p.NewObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.UserItems)
            .WithOne(p => p.UserObject);
        modelBuilder.Entity<ModelDifference>()
            .HasMany(t => t.Aspects)
            .WithOne(t => t.Owner)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber)
                  .HasName("PK_INVOICE_INVOICE_NUMBER");

            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");

            entity.Property(e => e.ContractNumber).HasColumnName("CONTRACT_NUMBER");

            entity.Property(e => e.Customer).HasColumnName("CUSTOMER");

            entity.Property(e => e.InvoiceId).HasColumnName("INVOICE_ID");

            entity.Property(e => e.PoNumber).HasColumnName("PO_NUMBER");

            entity.Property(e => e.ChangedBy).HasColumnName("CHANGED_BY");

            entity.Property(e => e.ChangedOn).HasColumnName("CHANGED_ON");

            entity.Property(e => e.GroupName).HasColumnName("GROUP_NAME");

            entity.Property(e => e.Closed).HasColumnName("CLOSED");

            entity.Property(e => e.InvoiceStarted).HasColumnName("INVOICE_STARTED");

            entity.Property(e => e.InvoiceSchedDate).HasColumnName("INVOICE_SCHED_DATE");

            entity.Property(e => e.InvoicedOn).HasColumnName("INVOICED_ON");

            entity.Property(e => e.InvoicedBy).HasColumnName("INVOICED_BY");

            entity.Property(e => e.ExchangeFactor).HasColumnName("EXCHANGE_FACTOR");

            entity.Property(e => e.ItemTotal).HasColumnName("ITEM_TOTAL");

            entity.Property(e => e.AdjustmentTotal).HasColumnName("ADJUSTMENT_TOTAL");

            entity.Property(e => e.AmountDue).HasColumnName("AMOUNT_DUE");

            entity.Property(e => e.PaymentDue).HasColumnName("PAYMENT_DUE");

            entity.Property(e => e.InvoiceComments).HasColumnName("INVOICE_COMMENTS");

            entity.Property(e => e.InternalComments).HasColumnName("INTERNAL_COMMENTS");

            entity.Property(e => e.PrintCount).HasColumnName("PRINT_COUNT");

            entity.Property(e => e.PrintedBy).HasColumnName("PRINTED_BY");

            entity.Property(e => e.PrintedOn).HasColumnName("PRINTED_ON");

            entity.Property(e => e.LastPrintFile).HasColumnName("LAST_PRINT_FILE");

            entity.Property(e => e.TCumulativeId).HasColumnName("T_CUMULATIVE_ID");

            entity.Property(e => e.TCustomerGroup).HasColumnName("T_CUSTOMER_GROUP");

            entity.Property(e => e.TCustomerPO).HasColumnName("T_CUSTOMER_PO");

            entity.Property(e => e.TFinSysExportOn).HasColumnName("T_FIN_SYS_EXPORT_ON");

            entity.Property(e => e.TInvoiceMonth).HasColumnName("T_INVOICE_MONTH");

            entity.Property(e => e.TInvoiceYear).HasColumnName("T_INVOICE_YEAR");

            entity.Property(e => e.TPdfFile).HasColumnName("T_PDF_FILE");

            entity.Property(e => e.TReviewReq).HasColumnName("T_REVIEW_REQ");
        });
    }
}

public class LabBIAuditingDbContext : DbContext {
    public LabBIAuditingDbContext(DbContextOptions<LabBIAuditingDbContext> options) : base(options) {
    }
    public DbSet<AuditDataItemPersistent> AuditData { get; set; }
    public DbSet<AuditEFCoreWeakReference> AuditEFCoreWeakReference { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.AuditItems)
            .WithOne(p => p.AuditedObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.OldItems)
            .WithOne(p => p.OldObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.NewItems)
            .WithOne(p => p.NewObject);
        modelBuilder.Entity<AuditEFCoreWeakReference>()
            .HasMany(p => p.UserItems)
            .WithOne(p => p.UserObject);
    }
}
