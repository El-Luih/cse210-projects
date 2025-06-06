using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{newAssignment.GetSummary()}\n");

        MathAssignment newMath = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine($"{newMath.GetHomerworkList()}\n");

        WritingAssignment newWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetWritingInformation());
    }
}