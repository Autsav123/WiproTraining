using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Myapp1.Data1;
using Myapp1.Model;

namespace Myapp1.Pages.Catagories
{
    public class IndexModel : PageModel
    {
        private readonly Myapp1.Data1.Applicationcontext _context;

        public IndexModel(Myapp1.Data1.Applicationcontext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
