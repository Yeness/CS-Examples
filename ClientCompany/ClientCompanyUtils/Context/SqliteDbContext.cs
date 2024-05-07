using ClientCompanyData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClientCompanyUtils.Context
{
    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext()
        {
            
        }

        //protected readonly IConfiguration Configuration;

        //public SqliteDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(x => x.Guid);
            modelBuilder.Entity<Company>().HasKey(x => x.Guid);
            modelBuilder.Entity<Employee>().HasKey(x => x.Guid);
            modelBuilder.Entity<Request>().HasKey(x => x.Guid);

            modelBuilder.Entity<Request>().HasOne(r => r.Employee).WithMany(e => e.Requests).HasForeignKey(r => r.Employee_ID).HasConstraintName("EmployeeID");
            modelBuilder.Entity<Request>().HasOne(r => r.Company).WithMany(c => c.Requests).HasForeignKey(r => r.Company_ID).HasConstraintName("CompanyID");

            modelBuilder.Entity<ClientCompany>().HasKey(cc => new { cc.Client_Id, cc.Company_Id });
            modelBuilder.Entity<ClientCompany>().HasOne(cc => cc.Client).WithMany(c => c.ClientCompanies).HasForeignKey(cc => cc.Client_Id).HasConstraintName("ClientID");
            modelBuilder.Entity<ClientCompany>().HasOne(cc => cc.Company).WithMany(c => c.ClientCompanies).HasForeignKey(cc => cc.Company_Id).HasConstraintName("CompanyID");

            modelBuilder.Entity<CompanyEmployee>().HasKey(ce => new { ce.Company_Id, ce.Employee_Id });
            modelBuilder.Entity<CompanyEmployee>().HasOne(ce => ce.Company).WithMany(c => c.CompanyEmployees).HasForeignKey(ce => ce.Company_Id).HasConstraintName("CompanyID");
            modelBuilder.Entity<CompanyEmployee>().HasOne(ce => ce.Employee).WithMany(e => e.CompanyEmployees).HasForeignKey(ce => ce.Employee_Id).HasConstraintName("EmployeeID");

            modelBuilder.Entity<RequestClient>().HasKey(rc  => new { rc.Request_Id, rc.Client_Id });
            modelBuilder.Entity<RequestClient>().HasOne(rc => rc.Request).WithMany(r => r.RequestClients).HasForeignKey(rc => rc.Request_Id).HasConstraintName("RequestID");
            modelBuilder.Entity<RequestClient>().HasOne(rc => rc.Client).WithMany(c => c.RequestClients).HasForeignKey(rc => rc.Client_Id).HasConstraintName("ClientID");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Environment.GetEnvironmentVariable("DatabaseConnection"));
        }
    }
}
