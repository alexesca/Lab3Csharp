using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    /* Create student class that carries an ID of a name
        * and a list of grades from different assignments */
    public class Student
    {
        public int[] grades = new int[5];
        public string name = "Jon Doe";

        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grades = grades;
        }

        // Calculate each student's individual average
        public double getStudentAverage(Student student)
        {
            double total = 0;

            foreach (int grade in student.grades)
                total += grade;

            double studentAverage = total / student.grades.Length;
            return studentAverage;
        }

        // Calculate class average for each assignment
        public  double[] getAssignmentAverage(List<Student> list)
        {
            double[] totals = new double[5];

            for (int j = 0; j < list[0].grades.Length; j++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    totals[j] += list[i].grades[j];
                }
                totals[j] /= list.Count;
            }
            return totals;
        }

        // Calculate overall class average
        public double getClassAverage(List<Student> list)
        {
            double total = 0;

            foreach (Student stu in list)
                total += getStudentAverage(stu);

            double classAverage = total / list.Count;
            return classAverage;
        }
    }
}
