using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using konjac_sponges.Data;
using System;
using System.Linq;

namespace konjac_sponges.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new konjac_spongesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<konjac_spongesContext>>()))
            {
                // Look for any movies.
                if (context.SpongeClass.Any())
                {
                    return;   // DB has been seeded
                }

                context.SpongeClass.AddRange(
                    new SpongeClass
                    {
                        ProductName = "Soft sponge",
                        Price = 7.99,
                        SpongeSize = 5M,
                        Color = "White",
                        Shape = "Rectangle",
                        Review = 5
                    },

                    new SpongeClass
                    {
                        ProductName = "Hard sponge",
                        Price = 8.99,
                        SpongeSize = 7M,
                        Color = "Black",
                        Shape = "Round",
                        Review = 8
                    },

                    new SpongeClass
                    {
                        ProductName = "Baby sponge",
                        Price = 10.99,
                        SpongeSize = 5M,
                        Color = "Pink",
                        Shape = "Heart",
                        Review = 10
                    },

                    new SpongeClass
                    {
                        ProductName = "Gentlemens sponge",
                        Price = 15.99,
                        SpongeSize = 10M,
                        Color = "Red",
                        Shape = "Diamond",
                        Review = 10
                    },

                    new SpongeClass
                    {
                        ProductName = "Woman sponge",
                        Price = 9.99,
                        SpongeSize = 7M,
                        Color = "Blue",
                        Shape = "speare",
                        Review = 7
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge pro",
                        Price = 3.99,
                        SpongeSize = 4M,
                        Color = "Silver",
                        Shape = "Rectangle",
                        Review = 6
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge max",
                        Price = 8.99,
                        SpongeSize = 8M,
                        Color = "Black",
                        Shape = "Heart",
                        Review = 9
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra",
                        Price = 7.99,
                        SpongeSize = 5M,
                        Color = "Yellow",
                        Shape = "Round",
                        Review = 8
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra pro",
                        Price = 5.99,
                        SpongeSize = 10M,
                        Color = "Green",
                        Shape = "Owl",
                        Review = 5
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra pro max",
                        Price = 10.99,
                        SpongeSize = 7M,
                        Color = "White",
                        Shape = "Speare",
                        Review = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
