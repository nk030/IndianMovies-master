using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public IndexModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
