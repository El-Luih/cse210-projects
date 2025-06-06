using System.Reflection.PortableExecutable;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string student, string topic, string section, string problems) : base(student, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomerworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}