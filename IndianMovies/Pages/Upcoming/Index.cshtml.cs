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
    public class IndexModel : PageModel
    {
        private readonly IndianMovies.Data.IndianMoviesContext _context;

        public IndexModel(IndianMovies.Data.IndianMoviesContext context)
        {
            _context = context;
        }

        public IList<UpcomingMovies> UpcomingMovies { get;set; }

        public async Task OnGetAsync()
        {
            UpcomingMovies = await _context.UpcomingMovies.ToListAsync();
        }
    }
}
