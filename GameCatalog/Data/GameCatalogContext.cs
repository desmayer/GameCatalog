using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameCatalog.Models;

namespace GameCatalog.Data
{
    public class GameCatalogContext : DbContext
    {
        public GameCatalogContext (DbContextOptions<GameCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<GameCatalog.Models.Game> Game { get; set; }
    }
}
