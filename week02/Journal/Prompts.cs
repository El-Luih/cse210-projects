public class Prompts
{
    public List<string> _listOfPrompts = new List<string>
    {
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "Of all I did today, what would I like to do again?",
        "What I would have liked to change about today?",
        "What did I learn today?",
    };

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _listOfPrompts.Count - 1);
        return _listOfPrompts[index];
    }
}