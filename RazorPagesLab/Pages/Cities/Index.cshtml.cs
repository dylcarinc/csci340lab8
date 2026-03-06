using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Models;
using RazorPagesLab.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.Serialization;

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
            [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public SelectList? Country { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? CityCountry { get; set; }

       public async Task OnGetAsync()
    {
        // <snippet_search_linqQuery>
        IQueryable<string> countryQuery = from m in _context.City
                                        orderby m.Country
                                        select m.Country;
        // </snippet_search_linqQuery>

        var cities = from m in _context.City
                    select m;

        if (!string.IsNullOrEmpty(SearchString))
        {
            cities = cities.Where(s => s.Name.Contains(SearchString));
        }

        if (!string.IsNullOrEmpty(CityCountry))
        {
            cities = cities.Where(x => x.Country == CityCountry);
        }

        // <snippet_search_selectList>
        Country = new SelectList(await countryQuery.Distinct().ToListAsync());
        // </snippet_search_selectList>
        City = await cities.ToListAsync();
}
    }
}
