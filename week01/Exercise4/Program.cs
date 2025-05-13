using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbersList = new List<float>();

        float newNumber;

        do
        {
            Console.Write("Enter a number: ");
            newNumber = float.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbersList.Add(newNumber);
            }

        } while (newNumber != 0);

        float totalSum = 0;
        float largestNumber = 0;

        foreach (float number in numbersList)
        {
            totalSum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        float average = totalSum / numbersList.Count;

        Console.WriteLine($"The sum of the numbers is: {totalSum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}