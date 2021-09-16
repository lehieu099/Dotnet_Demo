using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dotnet_Demo.Models;

namespace Dotnet_Demo.Pages_Luctures
{
    public class CreateModel : PageModel
    {
        private readonly Dotnet_DemoContext _context;

        public CreateModel(Dotnet_DemoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lecture Lecture { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lecture.Add(Lecture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
