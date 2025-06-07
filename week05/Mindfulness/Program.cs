/*
- Added a new kind of activity: Positive Affirmations Activity.
- Added functionality to ask the user for a goal number of activities for the session.
- The number of activities is displayed before the menu. Once the user has completed the set number of activities, the program displays a congratulatory message.
- The program keeps a log of how many activities of each type have been performed in the current session. This log can be accessed by the user at any time during the session.
- A summary using the activity log is given to the user once a session is finished.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("How many activities you want to do today? ");
        int goal = int.Parse(Console.ReadLine().Trim());
        ActivityLog sessionLog = new ActivityLog(goal, 4);
        string running = "";
        while (running != "6")
        {
            Console.Clear();
            sessionLog.GoalTracker();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Positive Affirmations Activity");
            Console.WriteLine("   5. Session Log");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            running = Console.ReadLine().Trim();

            if (running == "1")
            {
                new BreathingActivity().Run();
                sessionLog.AddActivity(0);
            }
            else if (running == "2")
            {
                new ReflectingActivity().Run();
                sessionLog.AddActivity(1);
            }
            else if (running == "3")
            {
                new ListingActivity().Run();
                sessionLog.AddActivity(2);
            }
            else if (running == "4")
            {
                new PositiveAffirmationsActivity().Run();
                sessionLog.AddActivity(3);
            }
            else if (running == "5")
            {
                sessionLog.ActivitiesSummary();
                Console.Write("Press enter to go back to the menu.");
                Console.ReadLine();
            }
            else if (running == "6")
            {
                sessionLog.ActivitiesSummary();
                sessionLog.GoalTracker();
                Console.Write("\nGoodbye!");
            }
        }
    }
}