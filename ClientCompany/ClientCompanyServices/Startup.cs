using Microsoft.Extensions.DependencyInjection;

namespace ClientCompanyServices
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(options)
        }
    }
}
