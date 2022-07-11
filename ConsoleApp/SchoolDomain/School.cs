class School
{
    public SchoolClass Classes { get; set; }
    public Student[] Students { get; set; }
    public Teacher[] Teachers { get; set; }
    public SchoolStaff[] Staff { get; set; }
    public int SchoolRate { get; set; }
    private decimal AnnualBudget { get; set; }
    public School(SchoolClass classes, Student[] students, Teacher[] teachers, SchoolStaff[] staff)
    {
        Classes = classes;
        Students = students;
        Teachers = teachers;
        Staff = staff;
        AnnualBudget = SetAnnualBudget();
        SchoolRate = SetSchoolRate();
    }
    private decimal SetAnnualBudget()
    {
        throw new NotImplementedException();
    }
    public int SetSchoolRate()
    {
        throw new NotImplementedException();
    }
}