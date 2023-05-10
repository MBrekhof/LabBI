using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DevExpress.Persistent.BaseImpl.EFCore.AuditTrail;
using DevExpress.Persistent.BaseImpl.EF.Kpi;
using LabBI.Module.BusinessObjects;


namespace LabBI.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public  class LabBIContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<LabBIEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new LabBIEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public  class LabBIDesignTimeDbContextFactory : IDesignTimeDbContextFactory<LabBIEFCoreDbContext> {
	public virtual LabBIEFCoreDbContext CreateDbContext(string[] args) {
		//throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		var optionsBuilder = new DbContextOptionsBuilder<LabBIEFCoreDbContext>();
		optionsBuilder.UseSqlServer("Encrypt=false;Integrated Security=SSPI;Data Source=MARTINBREKHE5B0\\SQL2022;Initial Catalog=Labware8Migrate");
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
		return new LabBIEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(LabBIContextInitializer))]
public class LabBIEFCoreDbContext : DbContext
{
    public LabBIEFCoreDbContext(DbContextOptions<LabBIEFCoreDbContext> options) : base(options)
    {
    }
    //public virtual DbSet<ModuleInfo> ModulesInfo { get; set; }
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
    public DbSet<Account> Account { get; set; }
    public DbSet<Analysis> Analysis { get; set; }
    public DbSet<AnalysisApproval> AnalysisApproval { get; set; }
    public DbSet<AnalysisTypes> AnalysisTypes { get; set; }
    public DbSet<Batch> Batch { get; set; }
    public DbSet<BatchHdrTemplate> BatchHdrTemplate { get; set; }
    public DbSet<BatchHdrTmpFlds> BatchHdrTmpFlds { get; set; }
    public DbSet<BatchLink> BatchLink { get; set; }
    public DbSet<BatchObjects> BatchObjects { get; set; }
    public DbSet<BatchProtocol> BatchProtocol { get; set; }
    public DbSet<BatchStandard> BatchStandard { get; set; }
    public DbSet<CAccreditation> Accreditations { get; set; }
    public DbSet<CalcVariables> CalcVariables { get; set; }
    public DbSet<Catalogue> Catalogue { get; set; }
    public DbSet<CatalogueItem> CatalogueItem { get; set; } 
    public DbSet<CCharacter> Character { get; set; }
    public DbSet<CCharacterDetails> CharacterDetails { get; set; }
    public DbSet<CCntrlCrtData> cCntrlCrtData { get; set; }
    public DbSet<CDisclaimerCat> DisclaimerCat { get; set; }
    public DbSet<CDisclaimerReg> DisclaimerReg { get; set; }
    public DbSet<CDisclaimers> Disclaimers { get; set; }
    public DbSet<CollectionRun> CollectionRun { get; set; }
    public DbSet<CommonName> CommonName { get; set; }
    public DbSet<Component> Component { get; set; }
    public DbSet<ContainerType> ContainerType { get; set; }
    public DbSet<ContractQuote> ContractQuote { get; set; }
    public DbSet<CostItem> CostItem { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Instruments> Instruments { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
    public DbSet<InvoiceItem> InvoiceItem { get; set; }
    public DbSet<LabType> LabType { get; set; }
    public DbSet<List> List { get; set; }
    public DbSet<ListEntry> ListEntry { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<QcSamples> QcSamples { get; set; }
    public DbSet<Sample> Sample { get; set; }
    public DbSet<SampleRules> SampleRules { get; set; }
    public DbSet<SamplingPoint> SamplingPoint { get; set; }
    public DbSet<TAnalysisMethod> TAnalysisMethod { get; set; }
    public DbSet<TaxGroup> TaxGroup { get; set; }
    public DbSet<TaxPlan> TaxPlan { get; set; }
    public DbSet<TCertification> TCertification { get; set; }
    public DbSet<TCoaTemplate> TCoaTemplate { get; set; }
    public DbSet<TContainerGroup> TContainerGroup { get; set; }
    public DbSet<TDistributionItem> TDistributionItem { get; set; }
    public DbSet<TDistributionList> TDistributionList { get; set; }
    public DbSet<Test> Test { get; set; }
    public DbSet<TestList> TestList { get; set; }
    public DbSet<TestListEntry> TestListEntry { get; set; }
    public DbSet<TProgram> TProgram { get; set; }
    public DbSet<TProgramItem> TProgramItem { get; set; }
    public DbSet<TreatmentWorks> TreatmentWorks { get; set; }
    public DbSet<TReportHeader> TReportHeader { get; set; }
    public DbSet<TSampleType> TSampleType { get; set; }
    public DbSet<Units> Units { get; set; }
    public DbSet<Versions> Versions { get; set; }
    public DbSet<WaterSource> WaterSource { get; set; }
    public DbSet<Zone> Zone { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.Entity<LabBI.Module.BusinessObjects.ApplicationUserLoginInfo>(b =>
        {
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

        modelBuilder.Entity<InvoiceItem>()
           .HasKey(ii => ii.InvoiceItemNo)
           .HasName("PK_INVOICE_ITEM_INVOICE_ITEM_NO");

        modelBuilder.Entity<Sample>()
            .HasKey(ii => ii.SampleNumber)
            .HasName("PK_SAMPLE_SAMPLE_NUMBER");

    }
}


public  class LabBIAuditingDbContext : DbContext {
    public  LabBIAuditingDbContext(DbContextOptions<LabBIAuditingDbContext> options) : base(options) {
    }
    public  DbSet<AuditDataItemPersistent> AuditData { get; set; }
    public  DbSet<AuditEFCoreWeakReference> AuditEFCoreWeakReference { get; set; }

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
