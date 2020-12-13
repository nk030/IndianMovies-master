using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.Upcoming
{
    public class DeleteModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public DeleteModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UpcomingMovies UpcomingMovies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UpcomingMovies = await _context.UpcomingMovies.FirstOrDefaultAsync(m => m.UpcomingMovies_Id == id);

            if (UpcomingMovies == null)
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

            UpcomingMovies = await _context.UpcomingMovies.FindAsync(id);

            if (UpcomingMovies != null)
            {
                _context.UpcomingMovies.Remove(UpcomingMovies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
