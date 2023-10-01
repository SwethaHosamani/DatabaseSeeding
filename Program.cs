// See https://aka.ms/new-console-template for more information
using DatabaseSeeder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentProject.Models;

// // Console.WriteLine("Hello, World!");
// using System;

// namespace DatabaseSeeder
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Seeding database...");
//             var serviceProvider = new ServiceCollection().AddDbContext<TestDemoContext>().BuildServiceProvider();
//             Seeder.Initialize(serviceProvider);
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         using (var context = new TestDemoContext())
//         {
//             Seeder.Initialize(context);
//         }
//     }
// }
class Program
{
    static void Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<TestDemoContext>()
            .UseSqlServer("Server=DESKTOP-RDT234N\\SQLEXPRESS;Database=TestDemo;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;")
            .Options;

        using (var context = new TestDemoContext(options))
        {
            Seeder.Initialize(context);
        }
    }
}
