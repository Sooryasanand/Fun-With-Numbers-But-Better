using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fun_with_number_but_bettter
{
    internal class Menu
    {
        // Values for the menu
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private string AscII;

        public Menu(string prompt, string[] options)
        {
            // Sends the values to the variable to the main screen
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {

            // The Menu
            Clear();
            WriteLine("");
            WriteLine(@"####### #     # #     #         #     # ### ####### #     #         #     # #     # #     # ######  ####### ######   #####  
#       #     # ##    #         #  #  #  #     #    #     #         ##    # #     # ##   ## #     # #       #     # #     # 
#       #     # # #   #         #  #  #  #     #    #     #         # #   # #     # # # # # #     # #       #     # #       
#####   #     # #  #  #         #  #  #  #     #    #######         #  #  # #     # #  #  # ######  #####   ######   #####  
#       #     # #   # #         #  #  #  #     #    #     #         #   # # #     # #     # #     # #       #   #         # 
#       #     # #    ##         #  #  #  #     #    #     #         #    ## #     # #     # #     # #       #    #  #     # 
#        #####  #     #          ## ##  ###    #    #     #         #     #  #####  #     # ######  ####### #     #  #####  
                                                                                                                                                ");

            WriteLine("");

            WriteLine("== Credits ==");
            WriteLine("");
            WriteLine("This a better and recreated application of original Fun With Number build by dingel");
            WriteLine("Music: Rick Astley - Never Gonna Give You Up");
            WriteLine("Music System Tutorial: Michael Hadley");
            WriteLine("Apple MacBook Pro M1");
            ForegroundColor = ConsoleColor.White;
            WriteLine("");
            WriteLine($"{Prompt}");
            WriteLine("Choose from the menu below: ");
            WriteLine("");

            // For loop to print out the selected options using i
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    // The line which is selected
                    prefix = ">";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    // The line which is not selected
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                    prefix = " ";
                }

                // How the line will be printed with the current option and the prefix.
                WriteLine($"{prefix} {currentOption}");
            }
            ResetColor();
        }

        public int Run()
        {
            // When the arrow key are pressed
            ConsoleKey keyPressed;
            do
            {
                Clear();
                // The Menu Display
                DisplayOptions();

                // What key is being pressed
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update Selected Index based on arrow keys
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    // Selected Index decreases when pressed up arrow key
                    SelectedIndex--;
                    // Goes back to the bottom of the list when it reaches the top of the list
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    // Selected Index increases when pressed up arrow key
                    SelectedIndex++;
                    // Goes back to the top of the list when it reaches the end of the list
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            // Returns the selected index
            return SelectedIndex;

        }
    }
}
