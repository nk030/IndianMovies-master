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
    public class DeleteModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public DeleteModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MoviesCollection = await _context.MoviesCollection.FindAsync(id);

            if (MoviesCollection != null)
            {
                _context.MoviesCollection.Remove(MoviesCollection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
