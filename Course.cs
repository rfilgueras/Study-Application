using System;
using static System.Console;
namespace StudyApplication
{
    public class Course
    {
        public string Title { get; set; }
        public string CurrentStudent { get; set; }

        public Course()
        {
            Title = "Study Application";
            Start();
        }

        public static void Start()
        {
            
            Student.StudentLogIn();
            Clear();
            WriteLine("Programming terms you should be familiar with:");
            Terms.TermItems();


        }

        /*public static void HUD(string studentName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==================================================");
            Console.ResetColor(); //resets color back to default
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Student: {studentName}");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"ID no: 695908");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Course: PROG 101: Introduction to Programming");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.WriteLine("==================================================\n");
            Console.ResetColor();
        }
        */

    }
}
