public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string Name, string topic, string title)
        : base(Name, topic)
    {

        _title = title;
    }

    public string GetWritingInformation()
    {
        string Name = GetName();

        return $"{_title} by {Name}";
    }
}