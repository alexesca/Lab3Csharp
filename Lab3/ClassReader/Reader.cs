using ClassStudent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassReader
{
    public class Reader
    {
        //This method checks if the file already exists
        public static bool checkIfFileExists(string file)
        {

            try
            {
                //Trying to read the file
                using (StreamReader reader = new StreamReader(file))
                {

                }
            }
            catch (Exception e)
            {
                //Returning an error message
                Console.Write("File not found! ");
                return false;
            }
            return true;
        }

        //This checks if teh file may be created so that we can read it and writ it. 
        public static bool checkIfFileMayBeCreated(String file)
        {

            try
            {
                if (file.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    return false;
                    //throw new System.InvalidOperationException("File cannot contain especial characters");
                }

                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), file)))
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                //Returning a message
                Console.Write("File not found");
                return false;
            }
        }

        //Reads teh file
        public static List<Student> readFile(String file)
        {
            List<Student> list = new List<Student>();
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    // Read until we reach the end of the file.
                    string str = "";
                    int line = 1;
                    do
                    {
                        //Reads a line
                        str = reader.ReadLine() + ",";

                        if (line > 1)
                        {
                            //Adding students to the list
                            addStudentToList(str, list);
                        }

                        line++;
                    }
                    //Conditional
                    while (!reader.EndOfStream);

                }
            }
            //Catches any exception
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception .", e);
            }

            return list;
        }


        // Append student to list
        static void addStudentToList(String str, List<Student> list)
        {
            List<String> strData;
            strData = splitStringLine(str);
            String name = getName(strData.ToArray());
            int[] grades = getGrades(strData.Skip(1).ToArray());
            Student student = new Student(name, grades);
            list.Add(student);
        }

        // Retrieve name from given data
        public static String getName(String[] data)
        {
            return data[0];
        }

        // Check for errors within an array of grades
        public static int[] getGrades(String[] data)
        {
            int[] grades = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    int num = Convert.ToInt32(data[i]);
                    grades[i] = num;
                }
                catch (Exception e)
                {
                    //Console.WriteLine("Error reading line {0}", i);
                    grades[i] = 0;
                }
            }
            return grades;
        }

        // Split string by comma
        public static List<String> splitStringLine(String line)
        {
            List<String> data = new List<String>();
            String tempString = "";
            foreach (char character in line)
            {
                if (character.CompareTo(',') == 0)
                {
                    data.Add(tempString);
                    tempString = "";
                }
                else
                {
                    tempString += character;
                }
            }

            return data;
        }
    }
}
