using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_webapp_mtest.Data;

namespace azure_webapp_mtest.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_webapp_mtest.Data.AppDBContext _context;

        public IndexModel(azure_webapp_mtest.Data.AppDBContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
