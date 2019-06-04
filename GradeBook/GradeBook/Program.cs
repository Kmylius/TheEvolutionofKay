using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kayla's Gradebook");

            while (true)
            {
                Console.WriteLine("Enter a grade or q to quit");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }

            var stats = book.GetStats();

            Console.WriteLine(Book.category);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($" The average grade is { stats.Average:N2}");
            Console.WriteLine($" The highest grade is { stats.High:N2}");
            Console.WriteLine($" The lowest grade is { stats.Low:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
