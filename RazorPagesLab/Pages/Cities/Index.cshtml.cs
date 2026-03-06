using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Models;
using RazorPagesLab.Data;

namespace RazorPagesLab.Pages.Cities
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public IndexModel(RazorPagesLab.Data.RazorPagesLabContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;

        public async Task OnGetAsync()
        {
            City = await _context.City.ToListAsync();
        }
    }
}
