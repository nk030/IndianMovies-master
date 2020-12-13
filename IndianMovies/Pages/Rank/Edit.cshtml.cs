using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.Rank
{
    public class EditModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public EditModel(IndianMovies.Data.IndianMoviesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ranking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankingExists(Ranking.Ranking_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RankingExists(int id)
        {
            return _context.Ranking.Any(e => e.Ranking_Id == id);
        }
    }
}
