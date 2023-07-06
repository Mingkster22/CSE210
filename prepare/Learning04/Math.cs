class Math : Assignment
{
    public string Topic { get; }
    public string Chapter { get; }

    public Math(string studentName, string assignmentType, string topic, string chapter)
        : base(studentName, assignmentType)
    {
        Topic = topic;
        Chapter = chapter;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nTopic: {Topic}\nChapter: {Chapter}";
    }

    public string GetHomeworkList()
    {
        return "Homework: Solve Exercise 1, Exercise 2, Exercise 3";
    }
}