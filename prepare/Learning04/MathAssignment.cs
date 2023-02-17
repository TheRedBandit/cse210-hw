public class MathAssignment : Assignment
{
    private string _textBookSelection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSelection, string problems)
        : base(studentName, topic)
    {
        _textBookSelection = textBookSelection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSelection} Problems {_problems}";
    }
}