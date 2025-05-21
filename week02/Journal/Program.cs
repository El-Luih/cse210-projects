using System;
using System.IO;

/* Stretch challenge: The program saves the journal in a .csv file. It handles commas by enclosing the values in double quotes, 
and it handles double quotes by replacing each double quote with two double quotes, effectively escaping them. 
The program can also load other journal-storing .csv files that follow these escaping and formatting methods by using Regular Expressions.*/
class Program
{
    static void Main(string[] args)
    {

        Journal newJournal = new Journal();
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options by typing the option number: \n");
            Console.WriteLine("1. Write a new entry \n2. Display current journal \n3. Load a journal from a file \n4. Save current journal into a .csv file \n5. Quit");
            Console.WriteLine("What would you like to do?");
            userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "1")
            {
                Prompts promptGenerator = new Prompts();
                string newPrompt = promptGenerator.GeneratePrompt();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newEntry._promptText = newPrompt;
                Console.WriteLine(newPrompt);
                newEntry._entryText = Console.ReadLine();
                newJournal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                newJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Please, enter the name of the file to load the journal from without file extensions:");
                string fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);
                Console.WriteLine($"The journal has been loaded from: {fileName}.csv");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Please, enter the name of the new file to save the journal to without file extensions:");
                string fileName = Console.ReadLine();
                newJournal.SaveToFile(fileName);
                Console.WriteLine($"Ther journal has been saved as: {fileName}.csv");
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}