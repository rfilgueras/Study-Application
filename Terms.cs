using System;
using static System.Console;
namespace StudyApplication
{
    public class Terms
    {
        public string Term { get; set; }
        public string Definition { get; set; }

        public static void TermItems ()
        {
            string[] Term = new string[5];
            Term[0] = "class\n - have attributes(properties) and operations(functions)";
            Term[1] = "System\n - a namespace that contains commonly used classes";
            Term[2] = "Console\n - a class of standard input, output and error streams foor Console application";
            Term[3] = "Dot Notation\n - used to refernce something from the library in the hierarchy path ans is expressed in code with dots between elements";
            Term[4] = "Class Diagram\n - describes a template for creating multiple versions of something";

            for (int i = 0; i < Term.Length; i++)
            {
                string termitems = $"{Term[i]}";
                Console.WriteLine(termitems);
            }


        }
    }
}
