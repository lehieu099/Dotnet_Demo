using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dotnet_Demo.Models;

namespace Dotnet_Demo.Pages_Luctures
{
    public class DeleteModel : PageModel
    {
        private readonly Dotnet_DemoContext _context;

        public DeleteModel(Dotnet_DemoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lecture Lecture { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecture = await _context.Lecture.FirstOrDefaultAsync(m => m.ID == id);

            if (Lecture == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecture = await _context.Lecture.FindAsync(id);

            if (Lecture != null)
            {
                _context.Lecture.Remove(Lecture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
