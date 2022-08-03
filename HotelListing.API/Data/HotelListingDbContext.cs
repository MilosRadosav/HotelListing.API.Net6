using HotelListing.API.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : IdentityDbContext<APIUser>
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)

        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfigurations());

            modelBuilder.ApplyConfiguration(new CountryConfigurations());

            modelBuilder.ApplyConfiguration(new HotelConfigurations());

            

        }
    }
}
