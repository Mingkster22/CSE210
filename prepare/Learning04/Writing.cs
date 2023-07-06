class Writing : Assignment
{
    public string Subject { get; }

    public Writing(string studentName, string assignmentType, string subject)
        : base(studentName, assignmentType)
    {
        Subject = subject;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nSubject: {Subject}";
    }

    public string GetWritingInformation()
    {
        return "Writing Information: Write a 500-word essay on the given subject.";
    }
}