namespace ConsoleApp.School;

public class Pupil
{
    public SchoolingClass SchoolingClass { get; set; }
    private ReportCard[] ReportCards { get; set; }

    public ReportCard GetReportCard(DateTime start)
    {
        foreach (ReportCard card in ReportCards)
        {
            if (card.StartingAcademicYear == start)
            {
                return card;
            }
        }
        return new ReportCard();
    }

    public string GetStandartName()
    {
        return $"firstName lastName";
    }
}