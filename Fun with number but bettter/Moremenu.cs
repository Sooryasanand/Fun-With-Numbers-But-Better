using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fun_with_number_but_bettter
{
    internal class Moremenu
    {
        // Values for the menu
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private string AscII;

        public Moremenu(string prompt, string[] options, string ascII)
        {
            // Sends the values to the variable to the main screen
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
            AscII = ascII;
        }

        private void DisplayOptions()
        {
            // The Menu
            WriteLine("");
            WriteLine($"{AscII}");
            WriteLine($"{Prompt}");
            WriteLine("Choose from the extra options below: ");
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

                // How the line will be printed with the current option.
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
                Console.Clear();
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
