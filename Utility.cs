using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DataStudyApplication
{
    class Utility
    {
        // Welcome message for players.
        public static void WelcomeTitle()
        {
            Title = "Branching Study Application Start";
            string title = @"
      __...--~~~~~-._   _.-~~~~~--...__              _____ _             _                              _ _           _   _               ___    ___  
    //               `V'               \\           / ____| |           | |           /\               | (_)         | | (_)             |__ \  / _ \ 
   //                 |                 \\         | (___ | |_ _   _  __| |_   _     /  \   _ __  _ __ | |_  ___ __ _| |_ _  ___  _ __      ) || | | |
  //__...--~~~~~~-._  |  _.-~~~~~~--...__\\         \___ \| __| | | |/ _` | | | |   / /\ \ | '_ \| '_ \| | |/ __/ _` | __| |/ _ \| '_ \    / / | | | |     
 //__.....----~~~~._\ | /_.~~~~----.....__\\        ____) | |_| |_| | (_| | |_| |  / ____ \| |_) | |_) | | | (_| (_| | |_| | (_) | | | |  / /_ | |_| |
====================\\|//====================      |_____/ \__|\__,_|\__,_|\__, | /_/    \_\ .__/| .__/|_|_|\___\__,_|\__|_|\___/|_| |_| |____(_)___/ 
                    `---`                                                     __/ |          | |   | |                                                  
                                                                             |___/           |_|   |_|                                                  
            ";
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(title);
            ResetColor();
            WriteLine("Welcome to the Study Application 2.0!");
            Utility.Continue();
            Clear();

        }
        public static void Continue()
        {
            WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Asks player to enter something into console 
        public static string TryAnswer()
        {
            ForegroundColor = ConsoleColor.Cyan;
            var answer = ReadLine();
            ResetColor();
            if (answer == "")
            {
                WriteLine("You didn't type anything. Please try again");
                ForegroundColor = ConsoleColor.Cyan;
                return ReadLine();
            }
            return answer;
        }

        // Will let user know if their answer was correct
        public static void CorrectNotification()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("That is Correct!\nYour received +1 point!");
            WriteLine($"Your current score is: {Player.Score + 1}/15");
            ResetColor();
        }

        // Lets player know their answer was incorrect
        public static void IncorrectNotification()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Sorry, that answer was incorrect");
            WriteLine($"Your current score is: {Player.Score}/15");
            ResetColor();

        }

        // Aks player if tthey want to play the game again
        public static void PlayAgain()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("\nWould you like to try again?\nPlease press [ Y ] for 'yes' and [ N ] for 'no' ");
            ResetColor();
            var continuePlay = Console.ReadKey();
            switch (continuePlay.Key)
            {
                case ConsoleKey.Y:
                    Game.Run();
                    
                    break;
                case ConsoleKey.N:
                default:
                    WriteLine("Thank you for playing Trivia Tuesdays!");
                    break;
            }
        }
    }
}
