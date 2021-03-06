using System;

namespace Lab4_Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the exponent table generator!");
            Run();           
        }

        public static int PrintTable(int number)
        {
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======\t======\t======");
            for (int i = 1; i <= number; i++)
            {
                int squared = i * i;
                int cubed = squared * i;
                //EXTRA!!!I align with four white spaces by using{value, 5}. 1 is value, 4 spaces. So value + 4 spaces = 5. 
                Console.WriteLine($"{i,5}\t{squared,5}\t{cubed,5}");
            }
            return number;
        }

        public static void Run()
        {
            bool runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Please enter an integer.");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 1290)
                {
                    //EXTRAS
                    Console.WriteLine("Sorry that input is invalid, please enter a number between 1 and 1290");
                    continue;
                }

                PrintTable(input);

                //ask for continue. make sure user enters a 'y' or 'n'
                while (true)
                {
                    Console.WriteLine("Would you like to run again with a different positive integer? y/n");
                    string yesOrNo = Console.ReadLine().ToLower();
                    if (yesOrNo == "n")
                    {
                        runAgain = false;
                        Console.WriteLine("Bye, person.");
                        break;
                    }
                    else if (yesOrNo =="y")
                    {
                        runAgain = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That isn't an answer to my question.");
                    }
                }
            }
        }
    }
}
