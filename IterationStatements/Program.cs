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

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNumberRange();
            //Skip3Print();
            //Console.WriteLine($"Does 5 = 5? {AreWeEqual(5,5)}");
            //Console.WriteLine($"Is 5 Even or Odd? {EvenOrOdd(5)}");
            //Console.WriteLine($"Is 3 Positive or Negative? {PosOrNeg(3)}");
        }
    }
}
    