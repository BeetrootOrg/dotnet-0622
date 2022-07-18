public class SchoolingClass
{
    public TeachingStaff ClassTeacher { get; set; }
    public Learner[] Learners { get; set; }
    public int RoomNumber { get; set; }
    public string StudyProfile { get; set; }
    public string NameSchoolingClass { get; set; }
    public AssessmentJournal[] AssessmentJournals { get; set; }
    public TeachingStaff[] Teachers { get; set; }
}