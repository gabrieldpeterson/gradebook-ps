using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            var average = 0.0;
            var numberOfGrades = 0;

            foreach(double grade in grades)
            {
                result += grade;
                numberOfGrades = grades.Count;
                average = result / numberOfGrades;
            }

            Console.WriteLine($"Sum = {result}");
            System.Console.WriteLine($"Grade Count = {numberOfGrades}");
            System.Console.WriteLine($"Average = {average:N1}");
        }
    }
}
