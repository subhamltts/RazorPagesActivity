using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesCourse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCourseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCourseContext>>()))
            {
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        CourseID = "ILSWTTI101",
                        CourseTitle = "Software",
                        Duration = 42,
                        Owner = "Patrick",
                        AssessmentMode = "MCQ"
                    },

                    new Course
                    {
                        CourseID = "ILSWTTI102",
                        CourseTitle = "Software",
                        Duration = 41,
                        Owner = "Fred",
                        AssessmentMode = "MCQ"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
