using ChooseTheRestaurantApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChooseTheRestaurantApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                        .HasKey(restaurant => restaurant.Code);

            modelBuilder.Entity<Restaurant>()
                        .Property(restaurant => restaurant.Name)
                        .IsRequired();

            modelBuilder.Entity<Vote>()
                        .HasKey(vote => vote.Id);

            modelBuilder.Entity<Vote>()
                        .Property(vote => vote.PersonName)
                        .IsRequired();

            modelBuilder.Entity<Restaurant>()
                        .HasMany(restaurant => restaurant.Votes)
                        .WithOne();
        }
    }
}
