using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dotnet_Demo.Models;

namespace Dotnet_Demo.Pages.Persons
{
    public class DetailsModel : PageModel
    {
        private readonly Dotnet_DemoContext _context;

        public DetailsModel(Dotnet_DemoContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Person.FirstOrDefaultAsync(m => m.PersonID == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
