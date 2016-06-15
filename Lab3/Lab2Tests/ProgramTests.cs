using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Program;

namespace Lab2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void getNameTest()
        {
            String[] names = { "Tyler", "Cassidy" };

            String name = Program.getName(names);

            Assert.AreEqual(name, "Tyler");
        }

        [TestMethod()]
        public void getGradesTest()
        {
            String[] gradeList = { "97", "86", "59", "78", "99" };

            int[] grades = Program.getGrades(gradeList);
            int[] expected = { 97, 86, 59, 78, 99 };

            for (int i = 0; i < gradeList.Length; i++)
            {
                Assert.AreEqual(grades[i], expected[i]);
            }
        }

        [TestMethod()]
        public void splitStringLineTest()
        {
            List<String> words = Program.splitStringLine("Miranda,Motter,Anneli,Samantha");
            string[] expected = { "Miranda", "Motter", "Anneli", "Samantha" };

            for (int i = 0; i < words.Count; i++)
            {
                Assert.AreEqual(words[i], expected[i]);
            }
        }

        [TestMethod()]
        public void getStudentAverageTest()
        {
            int[] grades = { 97, 86, 59, 78, 99 };
            Student bob = new Student("Robert Altney", grades);

            double average = bob.getStudentAverage(bob);

            Assert.AreEqual(average, 83.8);
        }

        [TestMethod()]
        public void getAssignmentAverageTest()
        {
            int[] grades1 = { 97, 86, 59, 78, 99 };
            int[] grades2 = { 42, 98, 92, 89, 100 };

            Student bob = new Student("Robert Altney",
                grades1);
            Student larry = new Student("Larry Smith",
                grades2);

            List<Student> stus = new List<Student>();
            stus.Add(bob);
            stus.Add(larry);

            double[] actualAverages = bob.getAssignmentAverage(stus);
            double[] expectedAverages = { 69.5, 92, 75.5, 83.5, 99.5 };

            for (int i = 0; i < actualAverages.Length; i++)
            {
                Assert.AreEqual(actualAverages[i], expectedAverages[i]);
            }
        }

        [TestMethod()]
        public void getClassAverageTest()
        {
            int[] grades1 = { 97, 86, 59, 78, 99 };
            int[] grades2 = { 42, 98, 92, 89, 100 };

            Student bob = new Student("Robert Altney",
                grades1);
            Student larry = new Student("Larry Smith",
                grades2);

            List<Student> stuClass = new List<Student>();
            stuClass.Add(bob);
            stuClass.Add(larry);

            double average = bob.getClassAverage(stuClass);

            Assert.AreEqual(average, 84);
        }

        [TestMethod()]
        public void checkIfFileExistsTest()
        {
            Assert.IsTrue(Program.checkIfFileExists("abc.txt"));
        }

        [TestMethod()]
        public void checkIfFileMayBeCreatedTest()
        {
            Assert.IsTrue(Program.checkIfFileExists("abc.txt"));
        }
    }
}