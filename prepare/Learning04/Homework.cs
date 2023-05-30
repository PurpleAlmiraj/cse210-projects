public class Assignment
{
    private string _Name;
    private string _topic;

    public Assignment(string Name, string topic)
    {
        _Name = Name;
        _topic = topic;
    }

    public string GetName()
    {
        return _Name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _Name + " - " + _topic;
    }
}