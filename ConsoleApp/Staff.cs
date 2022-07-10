namespace ConsoleApp.School;
enum StaffDepartments
{
    Teachers,
    Administrator,
    Service,
    Security,
    Managment
}
class SchoolStaff
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    private string _staffDepartments { get; set; }
    public string JobTitle { get; set; }
    private int _salary;

    public SchoolStaff(string firstName, string lastName, string department, string position, int salary)
    {
        FirstName = firstName;
        LastName = lastName;
        _staffDepartments = department;
        JobTitle = position;
        _salary = salary;
    }

    private void DepartmentChange(string newDepartment)
    {
        _staffDepartments = newDepartment;
    }
    public void PositionChange(string newJobTitle)
    {
        JobTitle = newJobTitle;
    }
    public void SalaryChange(int newSalary)
    {
        _salary = newSalary;
    }
}