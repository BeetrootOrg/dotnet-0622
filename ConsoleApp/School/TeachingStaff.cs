namespace ConsoleApp.School;

public class TeachingStaff
{
    private SchoolingClass[] SchoolingClasses { get; set; }
    internal string MainCourse { get; set; }
    internal string[] AdditionalCourses { get; set; }
    internal string Position { get; set; }
    internal string Category { get; set; }

    public string[] GetListSchoolingClasses()
    {
        string[] list = new string[SchoolingClasses.Length];

        for (int a = SchoolingClasses.Length - 1; a > -1; ++a)
        {
            list[a] = SchoolingClasses[a].NameSchoolingClass;
        }
        return list;
    }
}