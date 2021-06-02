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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        List<double> grades;
        string name;
    }
}