public class MathAssignment : Assignment
{
    private string _Section;
    private string _problems;

    public MathAssignment(string Name, string topic, string Section, string problems)
        : base(Name, topic)
    {

        _Section = Section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_Section} Problems {_problems}";
    }
}