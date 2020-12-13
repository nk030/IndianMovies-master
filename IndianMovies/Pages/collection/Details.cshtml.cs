using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.collection
{
    public class DetailsModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public DetailsModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        public MoviesCollection MoviesCollection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MoviesCollection = await _context.MoviesCollection.FirstOrDefaultAsync(m => m.Moviescollection_Id == id);

            if (MoviesCollection == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
