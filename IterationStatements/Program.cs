namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintTwoK()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThrees()
        {
            for (int a = 3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualInts(int equalOne, int equalTwo)
        {
            var check = (equalOne == equalTwo) ? true : false;
            return check;
        }
        //Write a method to check whether a given number is even or odd
        public static bool EvenOdd(int checkEven)
        {
            if (checkEven % 2 == 0)
            {
                return true;
            }
            return false;
        }
        //Write a method to check whether a given number is positive or negative
        public static void PosNeg(int posCheck)
        {
            if (posCheck > 0 && posCheck! < 0)
            {
                Console.WriteLine($"{posCheck} is postive!");
            }
            else
            {
                Console.WriteLine($"{posCheck} is not positive");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("you can vote!");
            }
            else
            {
                Console.WriteLine("you cant vote.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void RangeCheck()
        {
            Console.WriteLine("give me a number please");
            int intCheck = int.Parse(Console.ReadLine());

            if (intCheck >= -10 && intCheck <= 10)
            {
                Console.WriteLine("your number is within range");
            }
            else
            {
                Console.WriteLine("your number is out of range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultipleTable(int multiNum)
        {
            for (int b = 1; b <= 12; b++)
            {
                Console.WriteLine(b * multiNum);
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            Console.WriteLine("1000 through - 1000:");
            PrintTwoK();
            Console.WriteLine("3 through 999 by 3:");
            PrintThrees();
            Console.WriteLine("equal integers?:");
            Console.WriteLine($"{EqualInts(10, 10)}");
            Console.WriteLine("even or odd?:");
            Console.WriteLine($"{EvenOdd(18)}");
            Console.WriteLine("positive or negative?:");
            PosNeg(-23);
            Console.WriteLine("voting age:");
            VotingAge(19);
            Console.WriteLine("-10 through 10 range (from the user):");
            RangeCheck();
            Console.WriteLine("1 through 12 multiplication table:");
            MultipleTable(3);
        }
    }
}
