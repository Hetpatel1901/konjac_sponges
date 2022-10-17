using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using konjac_sponges.Data;
using System;
using System.Linq;
// File: Seeddata.cs
// Author Name: Het Natvarbhai Patel
// Student i'd: 0805024

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

                //Adding alll seeddata here...
                context.SpongeClass.AddRange(
                    new SpongeClass
                    {
                        ProductName = "Soft sponge",
                        Price = 7.99,
                        SpongeSize = 5,
                        Color = "White",
                        Shape = "Rectangle",
                        Review = 5
                    },

                    new SpongeClass
                    {
                        ProductName = "Hard sponge",
                        Price = 8.99,
                        SpongeSize = 7,
                        Color = "Black",
                        Shape = "Round",
                        Review = 8
                    },

                    new SpongeClass
                    {
                        ProductName = "Baby sponge",
                        Price = 10.99,
                        SpongeSize = 5,
                        Color = "Pink",
                        Shape = "Heart",
                        Review = 10
                    },

                    new SpongeClass
                    {
                        ProductName = "Gentlemens sponge",
                        Price = 15.99,
                        SpongeSize = 10,
                        Color = "Red",
                        Shape = "Diamond",
                        Review = 10
                    },

                    new SpongeClass
                    {
                        ProductName = "Woman sponge",
                        Price = 9.99,
                        SpongeSize = 7,
                        Color = "Blue",
                        Shape = "speare",
                        Review = 7
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge pro",
                        Price = 3.99,
                        SpongeSize = 4,
                        Color = "Silver",
                        Shape = "Rectangle",
                        Review = 6
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge max",
                        Price = 8.99,
                        SpongeSize = 8,
                        Color = "Black",
                        Shape = "Heart",
                        Review = 9
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra",
                        Price = 7.99,
                        SpongeSize = 5,
                        Color = "Yellow",
                        Shape = "Round",
                        Review = 8
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra pro",
                        Price = 5.99,
                        SpongeSize = 10,
                        Color = "Green",
                        Shape = "Owl",
                        Review = 5
                    },

                    new SpongeClass
                    {
                        ProductName = "Sponge ultra pro max",
                        Price = 10.99,
                        SpongeSize = 7,
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
