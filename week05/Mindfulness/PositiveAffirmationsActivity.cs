public class PositiveAffirmationsActivity : Activity
{
    private List<string> _affirmations = new List<string>
    {
        "I am capable of achieving my goals.",
        "I am worthy of love and happiness.",
        "I embrace challenges as opportunities for growth.",
        "I am resilient and strong.",
        "I trust in my own abilities.",
        "I am grateful for all that I have.",
        "I radiate positivity and kindness.",
        "I am in control of my reactions.",
        "I choose joy and peace.",
        "Every day is a new opportunity to succeed."
    };

    public PositiveAffirmationsActivity()
        : base("Positive Affirmations", "This activity will help you cultivate a positive mindset by focusing on empowering statements. Repeat them to yourself and feel their truth.")
    {
    }


    private string RandomAffirmation()
    {
        Random generator = new Random();
        int affirmation = generator.Next(0, _affirmations.Count());
        return _affirmations[affirmation];
    }

    private void DisplayAffirmation()
    {
        Console.WriteLine($"--- {RandomAffirmation()} ---");
    }

    public void Run()
    {
        StartingMessage();
        Console.WriteLine("\nAs affirmations appear, you can repeat them aloud, type them out, or simply reflect on their meaning.");
        Console.Write("\nYou may begin in: ");
        Timer(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            DisplayAffirmation();
            Timer(6);
            Console.WriteLine();
        }

        Console.WriteLine();
        EndingMessage();
    }
}