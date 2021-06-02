using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double LowGrade()
        {
            var lowGrade = double.MaxValue;

            foreach(var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
            }

            return lowGrade;
        }

        public double HighGrade()
        {
            var highGrade = double.MinValue;

            foreach(var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
            }

            return highGrade;
        }

        public double Average()
        {
            var total = 0.0;

            foreach(var grade in grades)
            {
                total += grade;
            }

            var average = total / grades.Count;

            return average;
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"Highest Grade = {HighGrade()}");
            Console.WriteLine($"Lowest Grade = {LowGrade()}");
            Console.WriteLine($"Average = {Average():N3}");
        }

        List<double> grades;
        string name;
    }
}