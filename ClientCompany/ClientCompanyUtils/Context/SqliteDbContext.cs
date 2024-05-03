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

        protected readonly IConfiguration Configuration;

        public SqliteDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("DatabaseConnection"));
        }
    }
}
