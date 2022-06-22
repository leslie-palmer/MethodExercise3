using System;

namespace MethodExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThousandToThousand();
            ThreeByThree();
            AreTheySame(5, 5);
            AreTheySame(5, 6);
            OddOrEven(0);
            OddOrEven(4);
            OddOrEven(55);
            PosOrNeg(0);
            PosOrNeg(4);
            PosOrNeg(-5);
            LegalVoter(18);
            LegalVoter(17);
            InRange(14);
            InRange(3);
            MultiTable(145);
            MultiTable(54);
        }

        static void ThousandToThousand()
        {
            for (int i = 2000; i >= 0; i--)
            {
                Console.WriteLine(i - 1000);
            }
        }

        static void ThreeByThree()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static bool AreTheySame(int x, int y)
        {
            string result;
            result = (x == y) ? "The numbers are the same!" : "The numbers are not the same.";
            Console.WriteLine($"Are {x} and {y} the same?");
            Console.WriteLine(result);
            return (x == y);
        }

        static void OddOrEven(int x)
        {
            string result;
            if (x == 0)
            {
                result = "0 isn't even or odd!";
            } else
            {
                result = ((x % 2) == 0) ? "Your number is even!" : "Your number is odd!";
            }
            Console.WriteLine(result);
        }

        static void PosOrNeg(int x)
        {
            string result;
            if (x == 0)
            {
                result = "0 isn't positive or negative!";
            } else
            {
                result = (x > 0) ? "Your number is positive!" : "Your number is negative!";
            }
            Console.WriteLine(result);
        }

        static bool LegalVoter(int x)
        {
            string results;
            results = (x >= 18) ? "You're of legal age to vote!" : "Sorry, you're too young to vote.";
            Console.WriteLine(results);
            return (x >= 18);
        }

        static bool InRange(int x)
        {
            string results;
            results = (x <= 10 && x >= -10) ? "Your number is in range." : "Your number is out of range.";
            Console.WriteLine(results);
            return (x <= 10 && x >= -10);
        }

        static void MultiTable(int x)
        {
            int num;
            Console.WriteLine($"Multiples of {x}");
            for (int i = 1; i <= 12; i++)
            {
                if ((x % i) == 0)
                {
                    num = (x / i);
                    Console.WriteLine($"{num} x {i}");
                }
            }
            
        }
    }
}
