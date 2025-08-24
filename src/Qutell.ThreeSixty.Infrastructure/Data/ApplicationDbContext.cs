using Microsoft.EntityFrameworkCore;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;
using DomainTimeZone = Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups.TimeZone;



namespace Qutell.ThreeSixty.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AvailableService> AvailableServices { get; set; }
        public DbSet<CompanyScale> CompanyScales { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<PackageItem> PackageItems { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<BlockedNumber> BlockedNumbers { get; set; }
        public DbSet<EmployeeCheckout> EmployeeCheckouts { get; set; }
        public DbSet<ExceptionType> ExceptionTypes { get; set; }
        public DbSet<Nafath> Nafaths { get; set; }
        public DbSet<OptionSet> OptionSets { get; set; }
        public DbSet<OptionSetItem> OptionSetItems { get; set; }
        public DbSet<OrganizingSchedule> OrganizingSchedules { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<StaticPage> StaticPages { get; set; }
        public DbSet<TestNumber> TestNumbers { get; set; }
        public DbSet<FinanceYear> FinanceYears { get; set; }
        public DbSet<ShiftType> ShiftTypes { get; set; }
        public DbSet<DomainTimeZone> TimeZones { get; set; }
        public DbSet<TimeType> TimeTypes { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ArgumentNullException.ThrowIfNull(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
