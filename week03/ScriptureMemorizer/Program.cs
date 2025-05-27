using System;
using System.Net.Quic;
using System.Runtime.InteropServices;
// The program randomly selects from only those words that are not already hidden.
// The program also implements a rudimentary library of scriptures and randomly selects one.

class Program
{
    static void Main(string[] args)
    {

        ScriptureLibrary newLibray = new ScriptureLibrary();
        Scripture newScripture = newLibray.GetRandomScripture();
        string userInput = "";


        while (userInput.Trim().ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            if (newScripture.IsCompletelyHidden())
            {
                break;
            }
            newScripture.HideRandomWords(3);
        }
    }
}
