public class MathAssignment : Assignment
{
    private string _chapterSection;
    private string _exercises;

    public MathAssignment(string studentName, string subject, string chapterSection, string exercises)
        : base(studentName, subject)
    {
        _chapterSection = chapterSection;
        _exercises = exercises;
    }

    public string GetHomeworkList()
    {
        return $"Section {_chapterSection} Problems {_exercises}";
    }
}