namespace ConsoleApp.School;

public class SchoolingClass
{
    internal TeachingStaff ClassTeacher { get; set; }
    private Pupil[] Pupils { get; set; }
    private int RoomNumber { get; set; }
    public string StudyProfile { get; set; }
    public string NameSchoolingClass { get; set; }
    private AssessmentJournal[] AssessmentJournals { get; set; }
    private TeachingStaff[] Teachers { get; set; }

    public Pupil GetPupil(string name)
    {
        foreach (Pupil pupil in Pupils)
        {
            if (pupil.GetStandartName() == name)
            {
                return pupil;
            }
        }
        return new Pupil();
    }
}