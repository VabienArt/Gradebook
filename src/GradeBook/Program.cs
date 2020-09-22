using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");
            var grades = new List<double>(){73,86,93,45,89,91,79};
            foreach (var number in grades){
                book.addGrade(number);
            }
            var stats = book.GetStats();
            Console.WriteLine($"Low: {stats.Low}");
            Console.WriteLine($"High: {stats.High}");
            Console.WriteLine($"Average: {stats.Average:N1}");
        }
    }
}
