using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Data;
namespace RazorPagesLab.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesLabContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesLabContext>>()))
        {
            if (context == null || context.City == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.City.Any())
            {
                return;   // DB has been seeded
            }

            context.City.AddRange(
                new City
                {
                    Name = "London",
                    DateVisited = DateTime.Parse("2025-05-15"),
                    StateRegion = "England",
                    Country = "United Kingdom",
                    Population = 8600000,
                    DaysSpent = 2,
                },
                   new City
                {
                    Name = "Bruges",
                    DateVisited = DateTime.Parse("2025-05-18"),
                    StateRegion = "West Flanders",
                    Country = "Belgium",
                    Population = 118000,
                    DaysSpent = 3,
                },
                   new City
                {
                    Name = "Rothenburg",
                    DateVisited = DateTime.Parse("2025-05-21"),
                    StateRegion = "Bavaria",
                    Country = "Germany",
                    Population = 11385,
                    DaysSpent = 4,
                },
                   new City
                {
                    Name = "Vienna",
                    DateVisited = DateTime.Parse("2025-05-26"),
                    StateRegion = "Vienna",
                    Country = "United Kingdom",
                    Population = 2028000,
                    DaysSpent = 2,
                }
            );
            context.SaveChanges();
        }
    }
}