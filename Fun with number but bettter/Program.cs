using System;
using static System.Console;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;
using Fun_with_number_but_bettter;

namespace Fun_With_Numbers_Recreated
{

    class Program
    {

        // Used for Stats
        static ulong numbersEntered = 0;
        static ulong totalNum = 0;
        static ulong smallestnumber = 0;
        static ulong largestnumber = 0;
        static ulong coordinatesPlotted = 0;
        static string ConfirmedUserEmail;

        // Used to print ascII art images
        static string Image;
        static string Image1;
        static string Image2;
        static string Image3;
        static string Image4;
        static string Image5;
        static string Image6;
        static string Image7;
        static string Image8;
        static string Image9;
        static string Image10;
        static string Image11;
        static string Image12;
        static string Image13;
        static string Image14;
        static string Image15;
        static string Image16;
        static string Image17;
        static string Image18;
        static string Image19;
        static string Image20;
        static string Image21;
        static string Image22;
        static string Image23;
        static string Image24;
        static string Image25;
        static string Image26;
        static string Image27;
        static string Image28;
        static string Image29;
        static string Image30;
        static string Image31;
        static string Image32;
        static string Image33;
        static string Image34;
        static string Image35;
        static string Image36;
        static string Image37;
        static string Image38;
        static string Image39;
        static string Image40;
        static string Image41;

        // The Main Menu / starting point
        public static void Main(string[] args)
        {
            // Reads the stats
            ReadStats();

            for (; ; )
            {
                Clear();
                // The Header / prompt
                string prompt = "Welcome to Fun With Numbers";
                // Options
                string[] options = { "Check number features", "Plot numbers", "Check overall stats", "More Options", "Save and exits" };
                // Gets the selectedIndex from the Menu
                Menu menu = new Menu(prompt, options);
                int selectedIndex = menu.Run();

                // Opens the method based on the user's choice
                if (selectedIndex == 0)
                {
                    optionA();
                }
                else if (selectedIndex == 1)
                {
                    optionB();
                }
                else if (selectedIndex == 2)
                {
                    optionC();

                }
                else if (selectedIndex == 3)
                {
                    moreOptions();
                }
                else if (selectedIndex == 4)
                {
                    // Save the stats before exiting the application
                    SaveStats();
                    // Exits the Application
                    Environment.Exit(0);
                };
            }
        }

        static public void moreOptions()
        {
            for (; ; )
            {
                Console.Clear();
                // AscII art
                string ascII = @"####### #     # #     #         #     # ### ####### #     #         #     # #     # #     # ######  ####### ######   #####  
#       #     # ##    #         #  #  #  #     #    #     #         ##    # #     # ##   ## #     # #       #     # #     # 
#       #     # # #   #         #  #  #  #     #    #     #         # #   # #     # # # # # #     # #       #     # #       
#####   #     # #  #  #         #  #  #  #     #    #######         #  #  # #     # #  #  # ######  #####   ######   #####  
#       #     # #   # #         #  #  #  #     #    #     #         #   # # #     # #     # #     # #       #   #         # 
#       #     # #    ##         #  #  #  #     #    #     #         #    ## #     # #     # #     # #       #    #  #     # 
#        #####  #     #          ## ##  ###    #    #     #         #     #  #####  #     # ######  ####### #     #  #####  
                                                                                                                                                ";
                // The Header / prompt
                string prompt = "Welcome to Fun With Numbers Extra!!!";
                Console.WriteLine("Choose from the extra options below: ");

                // Options
                string[] options = { "The Ultimate Matrix", "The Ultimate Rick Roll", "Who Wants to be a Millionaire?", "Return" };

                // Gets the selectedIndex from the MoreMenu
                Moremenu mainMenu = new Moremenu(prompt, options, ascII);
                int selectedIndex = mainMenu.Run();

                // Opens the method based on the user's choice
                if (selectedIndex == 0)
                {
                    matrix();
                }
                else if (selectedIndex == 1)
                {
                    RickRoll();
                }
                else if (selectedIndex == 2)
                {
                    beMillionaire();
                }
                else if (selectedIndex == 3)
                {
                    // Returns the Application
                    return;
                }
            }
        }

        // When option A is clicked
        static public void optionA()
        {
            ulong Iswholenum = 0;

            // Used for Prime Numbers
            ulong a = 0;

            Console.Clear();
            Console.Write("Please enter a whole number that will be checked over: ");

            // To check if the user entered a whole number
            try
            {
                Iswholenum = ulong.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter a whole number");
                Brooks();
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                return;
            }

            ulong wholenum = Iswholenum;


            // If wholenum is a funny number then play rick roll
            if (wholenum == 69)
            {
                if (File.Exists("Sounds/NeverGonna.wav"))
                {
                    SoundPlayer sounds = new SoundPlayer("Sounds/NeverGonna.wav");
                    sounds.Load();
                    sounds.Play();
                }
            }

            // Gets the user input about the number
            Console.WriteLine("");
            Console.WriteLine("The features of " + wholenum + " are...");

            // Finds if the number is postive or negative
            if (wholenum > 0uL)
            {
                Console.WriteLine(" Positve");
            }
            else if (wholenum == 0uL)
            {
                Console.WriteLine(" Zero");
            }
            else
            {
                Console.WriteLine(" Negative");
            }

            // Finds if the number is Even or Odd
            if (wholenum % 2uL == 0uL)
            {
                Console.WriteLine(" Even");
            }
            else
            {
                Console.WriteLine(" Odd");
            }

            // Finds all the Factors of the number
            Console.Write(" Factors are ");
            for (ulong x = 1uL; x <= wholenum; x++)
            {
                if (wholenum % x == 0uL)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("");

            // Finds if the number is prime or not
            for (ulong i = 1uL; i <= wholenum; i++)
            {
                if (wholenum % i == 0uL)
                {
                    a++;
                }
            }
            if (a == 2uL)
            {
                Console.WriteLine(" is a prime number");
            }
            else
            {
                Console.WriteLine(" Is not a prime number");
            }

            // For the Stats
            if (numbersEntered == 0uL)
            {
                smallestnumber = wholenum;
                largestnumber = wholenum;
            }
            else
            {
                if (wholenum < smallestnumber)
                {
                    smallestnumber = wholenum;
                }

                else if (wholenum > largestnumber)
                {
                    largestnumber = wholenum;
                }
            }

            numbersEntered++;
            totalNum = wholenum + totalNum;



            Console.ReadKey();
            return;

        }


        // When option B is clicked 
        static public void optionB()
        {
            Console.Clear();
            // Create's a Plotter
            Console.WriteLine("                                             x axis");
            Console.WriteLine("      1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  1|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  2|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  3|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  4|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("y 5|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("a 6|                                                                                                                  |");
            Console.WriteLine("x  |                                                                                                                  |");
            Console.WriteLine("i 7|                                                                                                                  |");
            Console.WriteLine("s  |                                                                                                                  |");
            Console.WriteLine("  8|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  9|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 10|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 11|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 12|                                                                                                                  |");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("Enter a corrdinate below to be added to the plot");

            // Check to see the exit function is true or not
            bool exit = false;

            int IsxAxis;
            int IsyAxis;

            while (!exit)
            {
                Console.Write("x-axis: ");

                // Gets the x-axis and saves them
                try
                {
                    IsxAxis = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a whole number");
                    Console.WriteLine("");
                    Brooks();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    return;
                }

                int xAxis = IsxAxis;

                // Checks if the x-axis is between our plotter
                if (xAxis >= 1 && xAxis <= 38)
                {
                    Console.Write("y-axis: ");

                    // Gets the y-axis and check if they are numbers them
                    try
                    {
                        IsyAxis = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter a whole number");
                        Brooks();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        return;
                    }

                    int yAxis = IsyAxis;

                    if (yAxis >= 1 && yAxis <= 12)
                    {
                        // Prints out the cursor from the axis's given by the user on to the plotter
                        Console.SetCursorPosition(0, 0);
                        Console.SetCursorPosition(3 + xAxis * 3, 1 + yAxis * 2);
                        Console.Write("x");
                        //Used For Stats
                        coordinatesPlotted++;
                        // For Spacing
                        Console.SetCursorPosition(0, 27);
                        Console.WriteLine("                                                      ");
                        Console.WriteLine("          ");
                        Console.WriteLine("          ");
                        Console.SetCursorPosition(0, 27);
                        // To Continue or Not
                        Console.Write("Do you wish to add another corrdinate (Y/N)? ");
                        // Gets user input and does accordingly.
                        string exitorno = Console.ReadLine().ToUpper();
                        if (exitorno == "N")
                        {
                            // Resets everything and goes back to the menu
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                            Console.Write("Please enter to return to the menu...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            return;
                        }
                        else if (exitorno == "Y")
                        {
                            // Repeats the code
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                        else
                        {
                            // Repeats the code
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                    }
                }
            }

            Console.ReadKey();
        }

        // When option C is clicked
        static public void optionC()
        {
            // Saves the stats
            SaveStats();

            // Prints the Stats to the screen
            Console.Clear();
            Console.WriteLine("Here are your stats: ");
            Console.WriteLine("");
            Console.WriteLine($" Numbers entered: {numbersEntered}");
            Console.WriteLine($" Total of numbers: {totalNum}");
            // To check if the totalNum and Numbers entered are 0
            if (totalNum == 0 && numbersEntered == 0)
            {
                Console.Write(" Average of numbers: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("N/A");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($" Average of numbers: {totalNum / numbersEntered}");
            }
            Console.WriteLine($" Smallest number entered: {smallestnumber}");
            Console.WriteLine($" Largest number entered: {largestnumber}");
            Console.WriteLine($" Coordinates plotted: {coordinatesPlotted}");
            Console.ReadKey();
            Console.WriteLine("");

            // Send the stats to your email address
            Console.Write(" Do you want this stats to be sent to your email in txt format?(Y/N) ");
            string selection = Console.ReadLine().ToUpper();

            bool exit = false;

            // If the user wants to send the stats to their email address
            if (selection == "Y")
            {
                // Saves the stats to Email stats txt file
                EmailSaveStats();
                while (!exit)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // Warning message
                    Console.WriteLine("[WARNING] The Email stats may not work if you are using School or Public network.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    // Gets the user's email id
                    Console.Write("Email Id: ");
                    string userConfirmEmail = Console.ReadLine();
                    // To check if the email id is blank or not
                    if (userConfirmEmail == "")
                    {
                        // Loop to repeat the code
                        continue;
                    }
                    // Confirm the email id
                    Console.WriteLine("Confirm this is your email id (Y/N): " + userConfirmEmail + " ");
                    string userConfirmAnswer = Console.ReadLine().ToUpper();
                    if (userConfirmAnswer == "Y")
                    {
                        // Sends the email and gives the user a confirmation message
                        ConfirmedUserEmail = userConfirmEmail;
                        sendEmail();
                        Console.WriteLine("");
                        Console.WriteLine("Stats have been send to your email id");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                return;
            }

        }

        // Saves the stats to the file
        static public void SaveStats()
        {
            // Create's the txt file
            StreamWriter myFile = File.CreateText("stats.txt");

            // Writes the values to the txt file
            myFile.WriteLine(numbersEntered);
            myFile.WriteLine(totalNum);
            myFile.WriteLine(smallestnumber);
            myFile.WriteLine(largestnumber);
            myFile.WriteLine(coordinatesPlotted);
            myFile.Close();
        }

        // Saves the stats to the email stats txt file
        static public void EmailSaveStats()
        {
            // Create's the txt file to email
            StreamWriter myEmailFile = File.CreateText("emailStats.txt");

            // Writes the values to the Email txt file
            myEmailFile.WriteLine(numbersEntered);
            myEmailFile.WriteLine(totalNum);
            myEmailFile.WriteLine(smallestnumber);
            myEmailFile.WriteLine(largestnumber);
            myEmailFile.WriteLine(coordinatesPlotted);
            myEmailFile.Close();
        }

        // Reads the stats from the file
        static public void ReadStats()
        {
            // To Check if the file exists or note
            if (!File.Exists("stats.txt"))
            {
                return;
            }

            StreamReader myFile = File.OpenText("stats.txt");
            numbersEntered = ulong.Parse(myFile.ReadLine());
            totalNum = ulong.Parse(myFile.ReadLine());
            smallestnumber = ulong.Parse(myFile.ReadLine());
            largestnumber = ulong.Parse(myFile.ReadLine());
            coordinatesPlotted = ulong.Parse(myFile.ReadLine());
            myFile.Close();
        }

        // Rick Roll Player
        static public void RickRoll()
        {
            // The music file
            string music = "Sounds/NeverGonna.wav";

            // To check if the music file exists or not
            if (!File.Exists(music))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: File does not exits! You have deleted the 'Sounds' folder or 'NeverGonna.wav' in 'Sounds' folder");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            // Can only play the music if the user's computer is Windows
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                SoundPlayer sounds = new SoundPlayer(music);
                sounds.Load();
                sounds.Play();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You need to run this app in Windows OS");
                Brooks();
                Console.ReadKey();
            }


        }

        // Function to send the email to the user
        static public void sendEmail()
        {
            // The file to send to the user
            string filepath = "emailStats.txt";
            string emailBody = "";

            DateTime now = DateTime.Now;
            string subject = "Stats file from Fun With Numbers";

            var host = Dns.GetHostEntry(Dns.GetHostName());

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(filepath);

            // The email body
            emailBody += "Hi,\r\n";
            emailBody += "This email is from Fun With Numbers regarding your stats file which you asked us to send to this email. If you did not ask please discard this email and delete it.\r\n";
            emailBody += "\r\n";
            emailBody += "Thanks and Regards,\r\n";
            emailBody += "Fun With Numbers\r\n";

            // the email client
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mailMessage = new MailMessage();

            // Information to send the email
            mailMessage.From = new MailAddress("streamflex40222@gmail.com");
            mailMessage.To.Add(ConfirmedUserEmail);
            mailMessage.Subject = subject;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("streamflex40222@gmail.com", "soorya2005");
            mailMessage.Body = emailBody;
            mailMessage.Attachments.Add(attachment);

            // Sends the email
            client.Send(mailMessage);
        }

        // Function to make your terminal look like the matrix terminal
        static public void matrix()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            // To confirm if the user what to continue or not
            Console.Write("You are going to enter a matrix terminal!!! Do you want to continue (Y/N)? ");
            string yesorno = Console.ReadLine().ToUpper();
            if (yesorno == "Y")
            {
                Console.Clear();
                int[,] arr = new int[3, 3];//declaration of 2D array  
                arr[0, 1] = 10;//initialization  
                arr[1, 2] = 20;
                arr[2, 0] = 30;


                while (Console.KeyAvailable == false)
                {
                    //traversal  
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.Write("");//new line at each row  
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.Write("");//new line at each row  
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.Write("");//new line at each row  
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.Write("");//new line at each row  
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.Write("");//new line at each row  
                    }

                }
            }
            else
            {
                // Return's the application to the main menu
                Console.ResetColor();
                return;
            }
        }

        // Function to read Mr Brooks Image from the stats file
        static public void ReadBrooks()
        {
            if (!File.Exists("Brooks.txt"))
            {
                return;
            }

            StreamReader brooksImage = File.OpenText("Brooks.txt");
            Image = brooksImage.ReadLine();
            Image1 = brooksImage.ReadLine();
            Image2 = brooksImage.ReadLine();
            Image3 = brooksImage.ReadLine();
            Image4 = brooksImage.ReadLine();
            Image5 = brooksImage.ReadLine();
            Image6 = brooksImage.ReadLine();
            Image7 = brooksImage.ReadLine();
            Image8 = brooksImage.ReadLine();
            Image9 = brooksImage.ReadLine();
            Image10 = brooksImage.ReadLine();
            Image11 = brooksImage.ReadLine();
            Image12 = brooksImage.ReadLine();
            Image13 = brooksImage.ReadLine();
            Image14 = brooksImage.ReadLine();
            Image15 = brooksImage.ReadLine();
            Image16 = brooksImage.ReadLine();
            Image17 = brooksImage.ReadLine();
            Image18 = brooksImage.ReadLine();
            Image19 = brooksImage.ReadLine();
            Image20 = brooksImage.ReadLine();
            Image21 = brooksImage.ReadLine();
            Image22 = brooksImage.ReadLine();
            Image23 = brooksImage.ReadLine();
            Image24 = brooksImage.ReadLine();
            Image25 = brooksImage.ReadLine();
            Image26 = brooksImage.ReadLine();
            Image27 = brooksImage.ReadLine();
            Image28 = brooksImage.ReadLine();
            Image29 = brooksImage.ReadLine();
            Image30 = brooksImage.ReadLine();
            Image31 = brooksImage.ReadLine();
            Image32 = brooksImage.ReadLine();
            Image33 = brooksImage.ReadLine();
            Image34 = brooksImage.ReadLine();
            Image35 = brooksImage.ReadLine();
            Image36 = brooksImage.ReadLine();
            Image37 = brooksImage.ReadLine();
            Image38 = brooksImage.ReadLine();
            Image39 = brooksImage.ReadLine();
            Image40 = brooksImage.ReadLine();
            Image41 = brooksImage.ReadLine();

            brooksImage.Close();
        }

        // Function to print Mr Brooks Image to the terminal
        static public void Brooks()
        {
            Console.WriteLine("");
            ReadBrooks();
            Console.WriteLine(Image);
            Console.WriteLine(Image1);
            Console.WriteLine(Image2);
            Console.WriteLine(Image3);
            Console.WriteLine(Image4);
            Console.WriteLine(Image5);
            Console.WriteLine(Image6);
            Console.WriteLine(Image7);
            Console.WriteLine(Image8);
            Console.WriteLine(Image9);
            Console.WriteLine(Image10);
            Console.WriteLine(Image11);
            Console.WriteLine(Image12);
            Console.WriteLine(Image13);
            Console.WriteLine(Image14);
            Console.WriteLine(Image16);
            Console.WriteLine(Image15);
            Console.WriteLine(Image17);
            Console.WriteLine(Image18);
            Console.WriteLine(Image19);
            Console.WriteLine(Image20);
            Console.WriteLine(Image21);
            Console.WriteLine(Image22);
            Console.WriteLine(Image23);
            Console.WriteLine(Image24);
            Console.WriteLine(Image25);
            Console.WriteLine(Image26);
            Console.WriteLine(Image27);
            Console.WriteLine(Image28);
            Console.WriteLine(Image29);
            Console.WriteLine(Image30);
            Console.WriteLine(Image31);
            Console.WriteLine(Image32);
            Console.WriteLine(Image33);
            Console.WriteLine(Image34);
            Console.WriteLine(Image36);
            Console.WriteLine(Image35);
            Console.WriteLine(Image37);
            Console.WriteLine(Image38);
            Console.WriteLine(Image39);
            Console.WriteLine(Image40);
            Console.WriteLine(Image41);
        }

        // Function to play the Millionaire game
        static public void beMillionaire()
        {
            Millionaire myGame = new Millionaire();
            myGame.Start();
        }
    }
}