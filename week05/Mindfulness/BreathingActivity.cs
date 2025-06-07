public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            Timer(3);
            Console.Write("Now breathe out...");
            Timer(3);
            Console.WriteLine();
        }
        EndingMessage();
    }
}