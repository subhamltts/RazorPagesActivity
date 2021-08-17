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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCourse.Data.RazorPagesCourseContext _context;

        public DetailsModel(RazorPagesCourse.Data.RazorPagesCourseContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
