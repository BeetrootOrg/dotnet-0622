namespace ConsoleApp.School;

public class AssessmentJournal
{
    public string PupilName { get; set; }
    private Subject[] Subjects { get; set; }
    internal string NameSchoolingClass { get; set; }
    private RecordAssessmentJournal[] Perfofmance { get; set; }

    public byte GetAssessment(DateTime day)
    {
        foreach (RecordAssessmentJournal record in Perfofmance)
        {
            if (record.LessonDate == day)
            {
                return record.Evaluations;
            }
        }
        return 0;
    }

    public Subject GetSubject(string subjectName)
    {
        foreach (Subject record in Subjects)
        {
            if (record.Name == subjectName)
            {
                return record;
            }
        }
        return new Subject();
    }
}