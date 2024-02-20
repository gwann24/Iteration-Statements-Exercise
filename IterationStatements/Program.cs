using System.Diagnostics.SymbolStore;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumberRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Skip3Print()
        {
            for (int s = 3; s<=999; s+=3)
            {
                Console.WriteLine(s);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool AreWeEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        
        //Write a method to check whether a given number is even or odd

        public static string EvenOrOdd (int num3)
        {
            return ((num3 % 2) == 0 ? "Even" : "Odd");
        }
        
        //Write a method to check whether a given number is positive or negative

        public static string PosOrNeg (int num4)
        {
            return (num4 < 0) ? "Negative" : "Positive";
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CheckVotingAge()
        {
            Console.WriteLine("Enter your age:");
            int.TryParse(Console.ReadLine(), out int age);
            if (age >= 18)
            {
                Console.WriteLine("Congratulations, you are eligible to vote!");
            } else
            {
                Console.WriteLine("Sorry, you are note eligible to vote.");
            }
         }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        public static void CheckUserNumber()
        {
            Console.WriteLine("Enter a Number:");
            int.TryParse(Console.ReadLine(), out int userInput);
            bool inRange = false;
            if (userInput >= -10 && userInput <= 10)
            {
                inRange = true;
            }
            Console.WriteLine($"Is your number {userInput} between -10 and 10? {inRange}");
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TimesTable1to12(int num5)
        {
            Console.WriteLine($"The multiplication table for {num5} from 1 to 12 is.");
            for (int t = 1;t <=12; t++)
            {
                Console.WriteLine($"{t} x {num5} = {num5 * t}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Lets have some FUN!\nHere are all the numbers from 1000 to -1000\nPress any key to start");
            Console.ReadLine();
            Console.Clear();
            PrintNumberRange();
            Console.WriteLine("\nDone\nNow let's skip count by 3 until we reach 999\nPress any key to start");
            Console.ReadLine();
            Console.Clear();
            Skip3Print();
            Console.WriteLine("\nDone\nLet's compare two numbers\nPress any key to start");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your first number");
            int.TryParse(Console.ReadLine(),out int compNum1);
            Console.WriteLine("Enter your second number");
            int.TryParse(Console.ReadLine(),out int compNum2);
            Console.WriteLine($"Does {compNum1} = {compNum2}? {AreWeEqual(compNum1,compNum2)}");
            Console.WriteLine("\nDone\nWe are rock'n and roll'n now!\nPress any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int userNum1);
            Console.WriteLine($"Is {userNum1} Even or Odd? {EvenOrOdd(userNum1)}");
            Console.WriteLine("\n\nEnter another number, use - for negative number");
            int.TryParse(Console.ReadLine(), out int userNum2);
            Console.WriteLine($"Is {userNum2} Positive or Negative? {PosOrNeg(userNum2)}");
            Console.WriteLine("\nDone\nLet's see if you can vote.\nPress any key to start");
            Console.ReadLine();
            Console.Clear();
            CheckVotingAge();
            Console.WriteLine("\nDone\nAlmost Done.\nPress any key to continue");
            Console.ReadLine();
            Console.Clear();
            CheckUserNumber();
            Console.WriteLine("\nDone\nLast one, I am going to help you with first grade math!\nPress any key to start");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int userNum3);
            TimesTable1to12(userNum3);
            Console.WriteLine("\n\nFINISHED!!!");
            Console.ReadLine();
        }
    }
}
    