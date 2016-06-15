using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ClassWriter
{
    public class Class1
    {
    }
}




//Student stu = new Student("Alex", new int[] { 3, 4, 5, 6, 6 });
//List<double> avgs = stu.getAssignmentAverage(list);

//                using (StreamWriter writer = new StreamWriter(outputFile))
//                {
//                    writer.WriteLine("Lastname, Firstname, avgGD");
//                    foreach (Student student in list)
//                    {
//                        // Initialize variables
//                        double average = student.getStudentAverage(student);
//List<string> names = student.name.Split(' ').ToList();
//names.Add(average.ToString());

//                        // Move last name to beginning and vice versa
//                        string temp = names[0];
//names[0] = names[1];
//                        names[1] = temp;

//                        // Concatenate strings
//                        string complete = string.Join(",", names);

//// Print to file
//writer.WriteLine(complete);
//                    }

//                    // Write last line of file
//                    writer.Write("AVERAGES,");

//                    foreach (double avg in avgs)
//                    {
//                        writer.Write(avg.ToString("f2"));
//                        writer.Write(',');
//                    }

//                    writer.Write(list[0].getClassAverage(list).ToString("f2"));
//                Console.WriteLine("The process was completed...");
//                }