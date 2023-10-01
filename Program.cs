// See https://aka.ms/new-console-template for more information
using DatabaseSeeder.Data;
using Microsoft.Extensions.DependencyInjection;
using StudentProject.Models;

// Console.WriteLine("Hello, World!");
using System;

namespace DatabaseSeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seeding database...");
            var serviceProvider = new ServiceCollection().AddDbContext<TestDemoContext>().BuildServiceProvider();
            Seeder.Initialize(serviceProvider);
        }
    }
}

