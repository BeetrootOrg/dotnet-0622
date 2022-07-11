class Student : Person
{
    public string StudentFirstName { get; set; }
    public string StudentLastname { get; set; }
    public int StudentAge { get; set; }
    private List<(string, int)> Marks { get; set; }

    public Student(string firstName,string lastName, int age, (string,byte) marks) : base(firstName, lastName, age)
    {
        StudentFirstName = firstName;
        StudentLastname = lastName;
        StudentAge = age;
        Marks = GetMarks();
    }
    private List<(string, int)> GetMarks()
    {
        throw new NotImplementedException();
    }
}