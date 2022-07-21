namespace ConsoleApp.School;

public class ReportCard
{
    private Subject[] Subjects { get; set; }
    public DateTime StartingAcademicYear { get; set; }
    public DateTime EndAcademicYear { get; set; }
    internal string NameSchoolingClass { get; set; }
    public string SchoolAddress { get; set; }
}