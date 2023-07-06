class Assignment
{
    public string StudentName { get; }
    public string AssignmentType { get; }

    public Assignment(string studentName, string assignmentType)
    {
        StudentName = studentName;
        AssignmentType = assignmentType;
    }

    public virtual string GetSummary()
    {
        return $"Student: {StudentName}\nAssignment Type: {AssignmentType}";
    }
}