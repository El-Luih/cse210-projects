public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    : base("Listing", "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.")
    {
    }

    private string RandomPrompt()
    {
        Random generator = new Random();
        int prompt = generator.Next(0, _prompts.Count());
        return _prompts[prompt];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"--- {RandomPrompt()} ---");
    }

    private List<string> ListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            userList.Add(Console.ReadLine().Trim());
        }
        return userList;
    }

    public void Run()
    {
        StartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        Timer(5);
        _count = ListFromUser().Count();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        EndingMessage();
    }
}