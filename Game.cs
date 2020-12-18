using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace DataStudyApplication
{
    class Game
    {
        
        public static void Run()
        {
            Utility.WelcomeTitle();
            Player.DisplayPlayerInfo();            
            Terms.DisplayQuestion();
            Terms.EndGameMessage();
            Player.Reset();
        }
    }
}
