using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dotnet_Demo.Models;

namespace Dotnet_Demo.Pages_Student
{
    public class IndexModel : PageModel
    {
        private readonly Dotnet_DemoContext _context;

        public IndexModel(Dotnet_DemoContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
