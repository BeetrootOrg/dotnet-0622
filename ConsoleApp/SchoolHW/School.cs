namespace ConsoleApp.SchoolHW;

class School
{
    public string SchoolName { get; init; }
    public Student[] SchoolStudents { get; set; }
    public Employee[] SchoolWorkers { get; set; }
    public Room[] SchoolRooms { get; set; }
    
    public void AddNewStudent(Student student)
    {
        AddNewStudentHelper(student);
    }
    private Student[] AddNewStudentHelper(Student student)
    {
        throw new NotImplementedException();
    }

    public void fireWorker(Employee worker)
    {
        throw new NotImplementedException();
    }
}