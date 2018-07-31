using GradeBook.Enums;
using System.Linq;
using System;

namespace GradeBook.GradeBooks
{
    /// <summary>
    /// Information Ranked-grading grades students not based on their individual performance,
    /// but rather their performance compared to their peers. This means the 20% of the students
    /// with the highest grade of a class get an A, the next highest 20% get a B, etc.
    /// </summary>
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5)
            {
                throw new InvalidOperationException("Min is 5 students for Ranked grading.");
            }

            // from total number of students, return/split 20% of them
            var groupStudentsNumber = (int)Math.Ceiling(Students.Count * 0.2);

            // Using Ling, sort the list into sorted list.
            var sortedGrades = Students.OrderByDescending(students => students.AverageGrade).
                Select(students => students.AverageGrade).ToList();

            if (sortedGrades[groupStudentsNumber - 1] <= averageGrade)
            {
                return 'A';
            }
            else if (sortedGrades[(groupStudentsNumber * 2) - 1] <= averageGrade)
            {
                return 'B';
            }
            else if (sortedGrades[(groupStudentsNumber * 3) - 1] <= averageGrade)
            {
                return 'C';
            }
            else if (sortedGrades[(groupStudentsNumber * 4) - 1] <= averageGrade)
            {
                return 'D';
            }

            return 'F';
        }

        /// <summary>
        /// 
        /// </summary>
        public override void CalculateStatistics()
        {
            if (Students.Count() < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students +" +
                    "with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStatistics();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count() < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students +" +
                    "with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }

    }
}
