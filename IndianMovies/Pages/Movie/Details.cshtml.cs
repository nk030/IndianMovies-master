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
    public class DetailsModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public DetailsModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.Movie_Id == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
