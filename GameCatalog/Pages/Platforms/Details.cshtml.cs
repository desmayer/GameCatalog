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
    public class DetailsModel : PageModel
    {
        private readonly GameCatalog.Data.GameCatalogContext _context;

        public DetailsModel(GameCatalog.Data.GameCatalogContext context)
        {
            _context = context;
        }

        public Platform Platform { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Platform = await _context.Platform.FirstOrDefaultAsync(m => m.PlatformId == id);

            if (Platform == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
