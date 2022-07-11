class Teacher : SchoolStaff
{
    public string TeacherFirstName { get; set; }
    public string TeacherLastname { get; set; }
    public int TeacherAge { get; set; }
    private decimal TeacherSalary { get; set; }
    public Staff TeacherPosition { get; } = Staff.Teacher;
    public Teacher(string firstName,string lastName, int age) : base(firstName, lastName, age)
    {
        TeacherFirstName = firstName;
        TeacherLastname = lastName;
        Age = age;
        TeacherSalary = CountSalary();

    }
    protected override decimal CountSalary()
    {
        throw new NotImplementedException();
    }
}