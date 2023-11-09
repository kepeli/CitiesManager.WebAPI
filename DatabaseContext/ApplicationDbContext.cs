using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City()
            { CityID = Guid.Parse("76166518-9AC6-44BB-A5E9-DDC48178BDD9"), CityName = "New York"  });

            modelBuilder.Entity<City>().HasData(new City()
            { CityID = Guid.Parse("8DD18C05-6876-4441-82A5-B1E196A70CE2"), CityName = "London" });

            modelBuilder.Entity<City>().HasData(new City()
            { CityID = Guid.Parse("938F1E6F-E11D-488B-947B-2C7EBCCAFA74"), CityName = "Lagos" }); 
        }
    }
}
