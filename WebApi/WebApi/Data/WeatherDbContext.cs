using Microsoft.EntityFrameworkCore;
using SSW.WebApi.Data.Entities;
using WebApi;

namespace SSW.WebApi.Data
{
    public class WeatherDbContext : DbContext
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<WeatherForecast> WeatherForecasts => Set<WeatherForecast>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasData(
                new WeatherForecast { Id = 1, Date = new DateTime(2022, 12, 6, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4229), TemperatureC = -10, Summary = Summaries[2] },
                new WeatherForecast { Id = 2, Date = new DateTime(2022, 12, 7, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4297), TemperatureC = 10, Summary = Summaries[3] },
                new WeatherForecast { Id = 3, Date = new DateTime(2022, 12, 8, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4299), TemperatureC = 30, Summary = Summaries[7] },
                new WeatherForecast { Id = 4, Date = new DateTime(2022, 12, 9, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4302), TemperatureC = 25, Summary = Summaries[4] }
                );

            base.OnModelCreating(modelBuilder);
        }
    }

}