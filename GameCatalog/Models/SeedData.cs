using GameCatalog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GameCatalog.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<GameCatalogContext>>()))
            {
                if (context.Game.Any())
                {
                    return;
                }

                context.AddRange(
                    new Game
                    {
                        Title = "God of War (2018)",
                        ReleaseDate = DateTime.Parse("2018-4-20"),
                        Genre = "Action-Adventure",
                        Price = 15.99M
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption II",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Action-Adventure",
                        Price = 15.99M
                    },
                    new Game
                    {
                        Title = "Marvel's Spider-Man",
                        ReleaseDate = DateTime.Parse("2018-9-07"),
                        Genre = "Action-Adventure",
                        Price = 15.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
