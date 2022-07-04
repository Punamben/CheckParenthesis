using System;

namespace CheckParantesisAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input string..:");
            var inputStr = Console.ReadLine();
            var charArr = inputStr.ToCharArray();

            if (Common.AreBracketsBalanced(charArr))
                Console.WriteLine("All parenthesis are balanced");
            else
                Console.WriteLine("Not balanced");
        }
    }
}
