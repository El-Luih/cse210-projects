public class ActivityLog
{
    private int _goal;
    private int _total = 0;
    private List<int> _activitiesCounter = new List<int>();

    public ActivityLog(int goal, int numberOfActivities)
    {
        _goal = goal;
        for (int i = 0; i < numberOfActivities; i++)
        {
            _activitiesCounter.Add(0);
        }
    }

    public void AddActivity(int activityIndex)
    {
        _total += 1;
        _activitiesCounter[activityIndex] += 1;
    }

    public void GoalTracker()
    {
        Console.WriteLine($"You have completed {_total} activities in this session.");
        if (_total >= _goal)
        {
            Console.WriteLine("You have achieved your goal!");
        }
        else
        {
            Console.WriteLine($"{_goal - _total} activities required to achieve your goal.\n");
        }
    }

    public void ActivitiesSummary()
    {
        Console.Clear();
        Console.WriteLine("--- Session summary ---\n");
        Console.WriteLine($"Breathing Activities: {_activitiesCounter[0]}");
        Console.WriteLine($"Reflecting Activities: {_activitiesCounter[1]}");
        Console.WriteLine($"Listing Activities: {_activitiesCounter[2]}");
        Console.WriteLine($"Positive Affirmations Activities: {_activitiesCounter[3]}");
        Console.WriteLine($"\nTotal activities: {_total}\n");
    }
}