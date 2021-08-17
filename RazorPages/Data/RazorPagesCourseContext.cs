using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages.Model;

namespace RazorPagesCourse.Data
{
    public class RazorPagesCourseContext : DbContext
    {
        public RazorPagesCourseContext (DbContextOptions<RazorPagesCourseContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages.Model.Course> Course { get; set; }
    }
}
