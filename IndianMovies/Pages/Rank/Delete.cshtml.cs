using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.Rank
{
    public class DeleteModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public DeleteModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ranking Ranking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ranking = await _context.Ranking.FirstOrDefaultAsync(m => m.Ranking_Id == id);

            if (Ranking == null)
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

            Ranking = await _context.Ranking.FindAsync(id);

            if (Ranking != null)
            {
                _context.Ranking.Remove(Ranking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
