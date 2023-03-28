using ChooseTheRestaurantApi.Data.Repositories;
using ChooseTheRestaurantApi.Data.Repositories.Interfaces;
using ChooseTheRestaurantApi.Services;
using ChooseTheRestaurantApi.Services.Interfaces;

namespace ChooseTheRestaurantApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

            services.AddScoped<IVoteService, VoteService>();
            services.AddScoped<IVoteRepository, VoteRepository>();
        }
    }
}
