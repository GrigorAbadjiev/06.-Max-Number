using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double maxNumber = double.MinValue;

            while (input != "Stop")
            {
                double inputAsNumber = double.Parse(input);

                if (inputAsNumber > maxNumber)
                {
                    maxNumber = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
