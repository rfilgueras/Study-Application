using System;
using static System.Console;
namespace StudyApplication
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public static void StudentLogIn()
        {
            WriteLine("Welcome to PROG 101: Introduction to Programming\n");
            string studentName = "Jane Doe";
            WriteLine("Please Log-in to continue");
            WriteLine("Enter Student Name:");
            ForegroundColor = ConsoleColor.Green;
            studentName = ReadLine();
            ResetColor();
            var code = "";     
            
            while (code != "secret")
            {
                try
                {
                    WriteLine("Enter password: (password is secret)");
                    ForegroundColor = ConsoleColor.Green;
                    code = ReadLine();
                    ResetColor();
                    if (code == "secret")
                    {

                        WriteLine("Authenticated Student Number: 695908. Press Enter to see Programming terms");
                        ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Not Authenticated. Try Again");
                }
                
            }
            
         
        }
    }
}
