using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace DataStudyApplication
{
    class Terms
    {
        public static string DataFile = "terms.txt";
        public static string Content = "(Empty File)";
        public static string Term = "terms.txt";
        public static string Definitions = "defintions.txt";

        public static List<string> TermName = new List<string>();
        public static List<string> TermDefinition = new List<string>();

        public static void Check()
        {
            if (File.Exists(DataFile))
            {
                Content = File.ReadAllText(DataFile);
            }

            Console.WriteLine(Content);
        }

        public static void UpdateTerms()
        {
            if (File.Exists(Term))
            {
                using (StreamReader sr = File.OpenText(Term))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        TermName.Add(s);
                    }
                }
            }

            if (File.Exists(Definitions))
            {
                using (StreamReader sr = File.OpenText(Definitions))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        TermDefinition.Add(s);
                    }
                }
            }
        }

        // Will display choices for the player to choose from and checks if the answer is correct
        public static void DisplayChoice()
        {           
            // Will display the definition from the definitions text file as a choice for user.
            for (int i = 0; i < TermName.Count; i++)
            {
                WriteLine($"{i}: {TermName[i]}");
               
            }
        }        

        public static void DisplayQuestion()
        {
            UpdateTerms();
            // Will display the question for every term in the text file.
            for (int i = 0; i < TermDefinition.Count; i++)
            {                
                ForegroundColor = ConsoleColor.Blue;

                WriteLine($"\n{TermDefinition[i]}?\n");
                ResetColor();
                DisplayChoice();
                String userAnswer = Utility.TryAnswer();
                // results userAnswer to an int
                int input = Int32.Parse(userAnswer);
                if (i == input)
                {
                    Utility.CorrectNotification();
                    Player.ScoreTraker();
                }
                else
                {
                    Utility.IncorrectNotification();
                }
                Utility.Continue();
                Clear();               
            }
        }


        // If player receives a certain amount of points after the game is over
        public static void EndGameMessage()
        {
            if (TermName.Count >= 15)
            {
                if (Player.Score <= 6)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Thats too bad!");
                    ResetColor();
                    Utility.PlayAgain();

                }
                if (Player.Score >= 10 && Player.Score != 10)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n Wow what a high score!");
                    ResetColor();
                    Utility.PlayAgain();
                }
                if (Player.Score == 15)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Congratulations! You just got a perfect Score!");
                    ResetColor();
                    Utility.PlayAgain();
                }
            }
        }
    }
}
