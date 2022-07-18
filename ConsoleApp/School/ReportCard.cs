public class ReportCard
{
    public Learner Learner { get; set; }
    public Subject[] Subjects { get; set; }
    public DateTime StartingAcademicYear { get; set; }
    public DateTime EndAcademicYear { get; set; }
    public string NameSchoolingClass { get; set; }
    public string SchoolAddress { get; set; }
}