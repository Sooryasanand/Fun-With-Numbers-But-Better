using Fun_With_Numbers_Recreated;
using System;

namespace Fun_with_number_but_bettter
{
    internal class Millionaire
    {
        public void Start()
        {
            // The Menu for the game
            Console.Clear();
            Console.WriteLine("Who Wants To Be A Mathematical Millionaire?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    HOW TO PLAY ");
            Console.ResetColor();
            Console.WriteLine("    I am ur chip on your computer.");
            Console.Write("    If you get any question wrong I will be ");
            Console.WriteLine("killed");
            Console.WriteLine("    So get all the questions right...");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    USE ARROW KEYS TO CYCLE THROUGH THE OPTIONS AND PRESS ENTER TO SELECT YOUR ANSWER ");
            Console.ResetColor();
            Console.WriteLine("    Press any key to continue...");
            Console.WriteLine("");
            Console.ReadKey();
            // Start's Question 1
            Question1();

            return;

        }

        public void Question1()
        {
            // Asking the question
            string prompt = "         What is 2 + 2         ";
            Console.WriteLine("");
            // Options for the answer
            string[] options = { "     A. 2    ", "     B. 5    ", "    C. 7     ", "     D. 4    " };
            // Gets the selectedIndex from the MillionaireMenu
            MillionaireMenu mainMenu = new MillionaireMenu(prompt, options);
            int selectedIndex = mainMenu.Run();

            // Checks to see if the selectedIndex is correct
            if (selectedIndex == 3)
            {
                // If the selectedIndex is correct
                Console.WriteLine("");
                Console.WriteLine("You are right!! Congratulations");
                Console.ReadKey();
                // Continues to the next question
                Question2();
            }
            else
            {
                // If the selectedIndex is wrong
                Wrong();
                return;
            }
        }

        public void Question2()
        {
            // Asking the question
            string prompt = "            90 ÷ 10            ";
            Console.WriteLine("");
            // Options for the answer
            string[] options = { "     A. 10   ", "     B. 9    ", "    C. 900   ", "     D. 1    " };
            // Gets the selectedIndex from the MillionaireMenu
            MillionaireMenu mainMenu = new MillionaireMenu(prompt, options);
            int selectedIndex = mainMenu.Run();

            // Checks to see if the selectedIndex is correct
            if (selectedIndex == 1)
            {
                // If the selectedIndex is correct
                Console.WriteLine("");
                Console.WriteLine("You are right!! Congratulations");
                Console.ReadKey();
                // Continues to the next question
                Question3();

            }
            else
            {
                // If the selectedIndex is wrong
                Console.WriteLine("You are Wrong");
                Console.WriteLine("Press any key to exit (except the powerbutton)");
                Console.ReadKey();
                return;
            }
        }

        public void Question3()
        {
            // Asking the question
            string prompt = "            72 x 3             ";
            Console.WriteLine("");
            // Options for the answer
            string[] options = { "     A. 372  ", "    B. 216   ", "   C. 106    ", "   D. 7230   " };
            // Gets the selectedIndex from the MillionaireMenu
            MillionaireMenu mainMenu = new MillionaireMenu(prompt, options);
            int selectedIndex = mainMenu.Run();

            // If the selectedIndex is correct
            if (selectedIndex == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("You are right!! Congratulations");
                Console.ReadKey();
                // Finishes the game and show's winning screen
                Winner();

            }
            else
            {
                // If the selectedIndex is wrong
                Console.WriteLine("You are Wrong");
                Console.WriteLine("Press any key to exit (except the powerbutton)");
                Console.ReadKey();
                // Quits the game
                return;
            }
        }

        public void Winner()
        {
            // Prints the Congratulations screen
            Console.Clear();
            Console.WriteLine(@"
  /$$$$$$   /$$$$$$  /$$   /$$  /$$$$$$  /$$$$$$$   /$$$$$$  /$$$$$$$$ /$$   /$$ /$$        /$$$$$$  /$$$$$$$$ /$$$$$$  /$$$$$$  /$$   /$$  /$$$$$$ 
 /$$__  $$ /$$__  $$| $$$ | $$ /$$__  $$| $$__  $$ /$$__  $$|__  $$__/| $$  | $$| $$       /$$__  $$|__  $$__/|_  $$_/ /$$__  $$| $$$ | $$ /$$__  $$
| $$  \__/| $$  \ $$| $$$$| $$| $$  \__/| $$  \ $$| $$  \ $$   | $$   | $$  | $$| $$      | $$  \ $$   | $$     | $$  | $$  \ $$| $$$$| $$| $$  \__/
| $$      | $$  | $$| $$ $$ $$| $$ /$$$$| $$$$$$$/| $$$$$$$$   | $$   | $$  | $$| $$      | $$$$$$$$   | $$     | $$  | $$  | $$| $$ $$ $$|  $$$$$$ 
| $$      | $$  | $$| $$  $$$$| $$|_  $$| $$__  $$| $$__  $$   | $$   | $$  | $$| $$      | $$__  $$   | $$     | $$  | $$  | $$| $$  $$$$ \____  $$
| $$    $$| $$  | $$| $$\  $$$| $$  \ $$| $$  \ $$| $$  | $$   | $$   | $$  | $$| $$      | $$  | $$   | $$     | $$  | $$  | $$| $$\  $$$ /$$  \ $$
|  $$$$$$/|  $$$$$$/| $$ \  $$|  $$$$$$/| $$  | $$| $$  | $$   | $$   |  $$$$$$/| $$$$$$$$| $$  | $$   | $$    /$$$$$$|  $$$$$$/| $$ \  $$|  $$$$$$/
 \______/  \______/ |__/  \__/ \______/ |__/  |__/|__/  |__/   |__/    \______/ |________/|__/  |__/   |__/   |______/ \______/ |__/  \__/ \______/ 
                                                                                                                                                    
                                                                                                                                                    
                                                                                                                                                    
 /$$     /$$ /$$$$$$  /$$   /$$       /$$   /$$  /$$$$$$  /$$    /$$ /$$$$$$$$       /$$      /$$  /$$$$$$  /$$   /$$                               
|  $$   /$$//$$__  $$| $$  | $$      | $$  | $$ /$$__  $$| $$   | $$| $$_____/      | $$  /$ | $$ /$$__  $$| $$$ | $$                               
 \  $$ /$$/| $$  \ $$| $$  | $$      | $$  | $$| $$  \ $$| $$   | $$| $$            | $$ /$$$| $$| $$  \ $$| $$$$| $$                               
  \  $$$$/ | $$  | $$| $$  | $$      | $$$$$$$$| $$$$$$$$|  $$ / $$/| $$$$$         | $$/$$ $$ $$| $$  | $$| $$ $$ $$                               
   \  $$/  | $$  | $$| $$  | $$      | $$__  $$| $$__  $$ \  $$ $$/ | $$__/         | $$$$_  $$$$| $$  | $$| $$  $$$$                               
    | $$   | $$  | $$| $$  | $$      | $$  | $$| $$  | $$  \  $$$/  | $$            | $$$/ \  $$$| $$  | $$| $$\  $$$                               
    | $$   |  $$$$$$/|  $$$$$$/      | $$  | $$| $$  | $$   \  $/   | $$$$$$$$      | $$/   \  $$|  $$$$$$/| $$ \  $$                               
    |__/    \______/  \______/       |__/  |__/|__/  |__/    \_/    |________/      |__/     \__/ \______/ |__/  \__/                               
                                                                                                                                                    
                                                                                                                                                    
                                                                                                                                                    
    /$$      /$$        /$$$$$$   /$$$$$$   /$$$$$$      /$$$$$$   /$$$$$$   /$$$$$$                                                                
  /$$$$$$  /$$$$       /$$$_  $$ /$$$_  $$ /$$$_  $$    /$$$_  $$ /$$$_  $$ /$$$_  $$                                                               
 /$$__  $$|_  $$      | $$$$\ $$| $$$$\ $$| $$$$\ $$   | $$$$\ $$| $$$$\ $$| $$$$\ $$                                                               
| $$  \__/  | $$      | $$ $$ $$| $$ $$ $$| $$ $$ $$   | $$ $$ $$| $$ $$ $$| $$ $$ $$                                                               
|  $$$$$$   | $$      | $$\ $$$$| $$\ $$$$| $$\ $$$$   | $$\ $$$$| $$\ $$$$| $$\ $$$$                                                               
 \____  $$  | $$      | $$ \ $$$| $$ \ $$$| $$ \ $$$   | $$ \ $$$| $$ \ $$$| $$ \ $$$                                                               
 /$$  \ $$ /$$$$$$ /$$|  $$$$$$/|  $$$$$$/|  $$$$$$//$$|  $$$$$$/|  $$$$$$/|  $$$$$$/                                                               
|  $$$$$$/|______/| $/ \______/  \______/  \______/| $/ \______/  \______/  \______/                                                                
 \_  $$_/         |_/                              |_/                                                                                              
   \__/                                                                                                                                             
                                                                                                                                                    
");
            Console.ReadKey();
            return;
        }

        public void Wrong()
        {
            // Prints "You are wrong" and quits the game
            Console.WriteLine("You are Wrong");
            Console.WriteLine("Press any key to exit (except the powerbutton)");
            Console.ReadKey();
            return;
        }
    }
}
