namespace ConsoleApp.School;

public class AssessmentJournal
{
    public string LearnerName { get; set; }
    public Subject Subject { get; set; }
    public string NameSchoolingClass { get; set; }
    private RecordAssessmentJournal[] Perfofmance { get; set; }

    public byte GetAssessment(DateTime day)
    {
        foreach (RecordAssessmentJournal record in Perfofmance)
        {
            if(record.LessonDate == day )
            {
                return record.Evaluations;
            }
        }
        return 0;
    }
}