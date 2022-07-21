namespace ConsoleApp.School;

public class Subject
{
    public string Name { get; set; }
    internal byte PointsEducationalPractice { get; set; }
    internal byte PointsFirstSemester { get; set; }
    internal byte PointsSecondSemester { get; set; }
    internal byte PointsYear { get; set; }
    internal byte PointsStateFinalCertification { get; set; }
    internal byte PointsFinal { get; set; }
    internal bool InvariantComponent { get; set; }
}