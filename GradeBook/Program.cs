using System;
using System.Collections.Generic;
using GradeBook.Enums;
using GradeBook.UserInterfaces;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#=======================#");
            Console.WriteLine("# Welcome to GradeBook! #");
            Console.WriteLine("#=======================#");
            Console.WriteLine();

            //var students = new List<Student>
            //{
            //    new Student("jamie",StudentType.Standard,EnrollmentType.Campus)
            //    {
            //        Grades = new List<double>{ 100, 102 }
            //    },
            //    new Student("john",StudentType.Standard,EnrollmentType.Campus)
            //    {
            //        Grades = new List<double>{ 75 }
            //    }
            //};

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.Name);
            //    foreach (var item in student.Grades)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            StartingUserInterface.CommandLoop();
            
            Console.WriteLine("Thank you for using GradeBook!");
            Console.WriteLine("Have a nice day!");
            Console.Read();
        }
    }
}