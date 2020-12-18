using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DataStudyApplication
{
    class Player
    {
        public string Name { get; set; }
        public static int Score { get; set; } = 0;

        public static string Answer = "";
        public static void ScoreTraker()
        {
            Score++;
        }
        public static void Reset()
        {
            Clear();
            Score = 0;
        }

        // Gets player's name and displays it on a HUD.
        public static void DisplayPlayerInfo()
        {
            WriteLine("Please enter a name");
            string playerName = Utility.TryAnswer();
            WriteLine($"\nReady to start the game {playerName}?");
            Utility.Continue();
            HUD();

            // Displays a HUD that will show current player and points
            void HUD()
            {
                Clear();
                string hudSeparator = "==================================================";
                ForegroundColor = ConsoleColor.White;
                WriteLine(hudSeparator);
                ForegroundColor = ConsoleColor.Cyan;
                Write($"Current Player: {playerName}\n");
                ResetColor();
                ForegroundColor = ConsoleColor.White;
                WriteLine($"{hudSeparator}\n");
                ResetColor();
            }
        }
    }

}
