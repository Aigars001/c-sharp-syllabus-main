using System;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string course1 = "English III";
            string course2 = "Precalculus";
            string course3 = "Music Theory";
            string course4 = "Biotechnology";
            string course5 = "Principles of Technology I";
            string course6 = "Latin II";
            string course7 = "AP US History";
            string course8 = "Business Computer Infomation Systems";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";
            string teacher4 = "Ms. Palmer";
            string teacher5 = "Ms. Garcia";
            string teacher6 = "Mrs. Barnett";
            string teacher7 = "Ms. Johannessen";
            string teacher8 = "Mr. James";

            int classLength1 = course1.Length;
            int classLength2 = course2.Length;
            int classLength3 = course3.Length;
            int classLength4 = course4.Length;
            int classLength5 = course5.Length;
            int classLength6 = course6.Length;
            int classLength7 = course7.Length;
            int classLength8 = course8.Length;
            

            int teacherLength1 = teacher1.Length;
            int teacherLength2 = teacher2.Length;
            int teacherLength3 = teacher3.Length;
            int teacherLength4 = teacher4.Length;
            int teacherLength5 = teacher5.Length;
            int teacherLength6 = teacher6.Length;
            int teacherLength7 = teacher7.Length;
            int teacherLength8 = teacher8.Length;
            

            int widthCourse = 37;
            int widthTeacher = 16;

            string borderLine = new string('-', 60);
            string rowClasses1 = new string(' ', widthCourse - classLength1);
            string rowClasses2 = new string(' ', widthCourse - classLength2);
            string rowClasses3 = new string(' ', widthCourse - classLength3);
            string rowClasses4 = new string(' ', widthCourse - classLength4);
            string rowClasses5 = new string(' ', widthCourse - classLength5);
            string rowClasses6 = new string(' ', widthCourse - classLength6);
            string rowClasses7 = new string(' ', widthCourse - classLength7);
            string rowClasses8 = new string(' ', widthCourse - classLength8);

            string rowTeachers1 = new string(' ', widthTeacher - teacherLength1);
            string rowTeachers2 = new string(' ', widthTeacher - teacherLength2);
            string rowTeachers3 = new string(' ', widthTeacher - teacherLength3);
            string rowTeachers4 = new string(' ', widthTeacher - teacherLength4);
            string rowTeachers5 = new string(' ', widthTeacher - teacherLength5);
            string rowTeachers6 = new string(' ', widthTeacher - teacherLength6);
            string rowTeachers7 = new string(' ', widthTeacher - teacherLength7);
            string rowTeachers8 = new string(' ', widthTeacher - teacherLength8);

            Console.WriteLine($"+{borderLine}+");
            Console.WriteLine($"| 1 |{rowClasses1}{course1} |{rowTeachers1}{teacher1} |");
            Console.WriteLine($"| 2 |{rowClasses2}{course2} |{rowTeachers2}{teacher2} |");
            Console.WriteLine($"| 3 |{rowClasses3}{course3} |{rowTeachers3}{teacher3} |");
            Console.WriteLine($"| 4 |{rowClasses4}{course4} |{rowTeachers4}{teacher4} |");
            Console.WriteLine($"| 5 |{rowClasses5}{course5} |{rowTeachers5}{teacher5} |");
            Console.WriteLine($"| 6 |{rowClasses6}{course6} |{rowTeachers6}{teacher6} |");
            Console.WriteLine($"| 7 |{rowClasses7}{course7} |{rowTeachers7}{teacher7} |");
            Console.WriteLine($"| 8 |{rowClasses8}{course8} |{rowTeachers8}{teacher8} |");
            Console.WriteLine($"+{borderLine}+");
        }
    }
}