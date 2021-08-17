using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Model;
using RazorPagesCourse.Data;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCourse.Data.RazorPagesCourseContext _context;

        public IndexModel(RazorPagesCourse.Data.RazorPagesCourseContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
