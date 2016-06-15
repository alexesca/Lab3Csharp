/* Program created by Miranda Motter and Alex Escamilla for the purpose of
 * calculating averages of given assignements, etc. from a given file of 
 * students and grade. CS 176-01, June 4-11 2016 */

using ClassReader;
using ClassStudent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            if (args.Length == 0 || args.Length < 2)
            {
                Console.Write("It needs one more arguments!!!");
                return;
            }
            String inputFile = args[0] + ".csv";
            String outputFile = args[1] + ".csv";

            if (!Reader.checkIfFileExists(inputFile))
            {
                return;
            }
            if (!Reader.checkIfFileMayBeCreated(outputFile))
                {
                    Console.Write("Filename contains invalid characters or already exists.");
                    return;
                }
                List<Student> list = Reader.readFile(inputFile);
            if (list.Count < 1)
            {
                Console.Write("more records");
                return;
            }

            //The program loads the list with the students
            WriteLine(list.First().name);

            /****************************
            This is the list (list) you need to use to calculate the GPA. 
            It is a list of  Student objects. You can access each student/element/object in the array
            and access the name. list[0].name list[3].grade
            *************************/

        }
    }
}