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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public DetailsModel(RazorPagesLab.Data.RazorPagesLabContext context)
        {
            _context = context;
        }

        public City City { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City.FirstOrDefaultAsync(m => m.Id == id);

            if (city is not null)
            {
                City = city;

                return Page();
            }

            return NotFound();
        }
    }
}
