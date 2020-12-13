using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndianMovies.Data;
using IndianMovies.Models;

namespace IndianMovies.Pages.Upcoming
{
    public class CreateModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public CreateModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UpcomingMovies UpcomingMovies { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UpcomingMovies.Add(UpcomingMovies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
