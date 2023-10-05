// using System;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using StudentProject.Models;
//usingCSVhelper;

// namespace DatabaseSeeder.Data
// {
//     public static class Seeder
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new TestDemoContext(
//                 serviceProvider.GetRequiredService<DbContextOptions<TestDemoContext>>()))
//             {
//                 if (context.StudentData.Any())
//                 {
//                     Console.WriteLine("Database already seeded.");
//                     return; 
//                 }

//                 var students = new StudentDatum[]
//                 {
//                     new StudentDatum
//                     {
//                         StudentId = "STDN00001",
//                         Gender = "F",
//                         Nationlity = "USA",
//                         PlaceOfBirth = "New York",
//                         StageId = "lowerlevel",
//                         GradeId = "G01",
//                         SectionId = "A",
//                         Topic = "Math",
//                         Semester = "F",
//                         Relation = "Mother",
//                         RaisedHands = 10,
//                         VisitedResources = 20,
//                         AnnouncementsView = 5,
//                         Discussion = 15,
//                         ParentAnsweringSurvey = "Yes",
//                         ParentschoolSatisfaction = "Good",
//                         StudentAbsenceDays = "Under-7",
//                         StudentMarks = 85,
//                         Classes = "M"
//                     },
//                     // Add more students as needed
//                 };

//                 context.StudentData.AddRange(students);
//                 context.SaveChanges();
//                 Console.WriteLine("Database seeded successfully.");
//             }
//         }
//     }
// }
using StudentProject.Models;  // Add appropriate namespace if needed

namespace DatabaseSeeder.Data
{
    public static class Seeder
    {
        public static void Initialize(TestDemoContext context)
        {
            if (context.StudentData.Any())
            {
                Console.WriteLine("Database already seeded.");
                return;
            }

            // Your seeding logic here

            context.SaveChanges();
            Console.WriteLine("Database seeded successfully.");
        }
    }
}
