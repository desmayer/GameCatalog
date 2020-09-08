using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameCatalog.Data;
using GameCatalog.Models;

namespace GameCatalog.Pages.Platforms
{
    public class IndexModel : PageModel
    {
        private readonly GameCatalog.Data.GameCatalogContext _context;

        public IndexModel(GameCatalog.Data.GameCatalogContext context)
        {
            _context = context;
        }

        public IList<Platform> Platform { get;set; }

        public async Task OnGetAsync()
        {
            Platform = await _context.Platform.ToListAsync();
        }
    }
}
