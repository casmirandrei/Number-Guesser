using System;

namespace NumberGuesser
{
    //Main CLass
    class Program
    {
        
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppInfo function 

            GreetUser(); // Ask for user name and greet user 
            
            while (true)
            {

                

                //Create a new Random object

                Random random = new Random();

               
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match gues to correct number
                    if (guess != correctNumber)
                    {
                        // Set error message 
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }


                }
                PrintColorMessage(ConsoleColor.Yellow, "Correct! You gessed it!");

                //Ask to play again
                Console.WriteLine("Do you want to play again? [Y or N] ");

                //Get answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N"){
                    return;
                }
                else
                {
                    return;
                }



            }
            }
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0";
            string appAuthor = "Andrei Casmir";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resets text color
            Console.ResetColor();
        }
        // Asks user name and greet
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color 
            Console.ForegroundColor = color;

            // Tell use it's not a number
            Console.WriteLine(message);

            //Resets text color
            Console.ResetColor();
        }

        }
    
}
