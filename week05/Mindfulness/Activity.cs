using System.Diagnostics.Contracts;

public class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    protected void Spinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(200);
            Console.Write("\b|");
            Thread.Sleep(200);
            Console.Write("\b/");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("Please, enter the amount of seconds you want this activity to last:");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get Ready");
        Spinner(5);
        Console.WriteLine("\n");
    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!");
        Spinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity.");
        Spinner(5);
        Console.Clear();
    }
}