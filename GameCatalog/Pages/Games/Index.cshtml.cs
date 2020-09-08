using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameCatalog.Data;
using GameCatalog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameCatalog.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly GameCatalog.Data.GameCatalogContext _context;

        public IndexModel(GameCatalog.Data.GameCatalogContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string GameGenre { get; set; }

        public SelectList Ratings { get; set; }
        [BindProperty(SupportsGet = true)]
        public string GameRating { get; set; }

        public async Task OnGetAsync()
        {
            //Genre
            IQueryable<string> genreQuery = from g in _context.Game
                                            orderby g.Genre
                                            select g.Genre;

            //Rating
            IQueryable<string> ratingQuery = from g in _context.Game
                                            orderby g.Rating
                                            select g.Rating;

            var games = from g in _context.Game
                       select g;

            if (!string.IsNullOrEmpty(SearchString))
            {
                games = games.Where(g => g.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(GameGenre))
            {
                games = games.Where(g => g.Genre == GameGenre);
            }

            if (!string.IsNullOrEmpty(GameRating))
            {
                games = games.Where(g => g.Rating == GameRating);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Ratings = new SelectList(await ratingQuery.Distinct().ToListAsync());
            Game = await games.ToListAsync();
        }
    }
}
