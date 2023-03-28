using ChooseTheRestaurantApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ChooseTheRestaurantApi.Configurations
{
    public static class DatabaseConfig
    {

        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<DataContext>(
                options => options.UseSqlite(configuration.GetConnectionString("core")));
        }
    }
}
