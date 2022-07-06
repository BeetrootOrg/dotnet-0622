namespace School;

class Teacher
{
    public string FirstName {get;init;}
    public string LastName {get;set;}
    private string HomeAddress {get;set;}
    public string Email {get;set;}
    private (string, string) ParentsPhoneNumbers {get;set;}
    private DateTime BirthDate {get;init;}
    private DateTime EmploymentDate {get;init;}
    public string Subject {get;set;}
    private double Salary {get;set;}

    public int GetAge()
    {
        return BirthDate > DateTime.Today.AddYears(BirthDate.Year - DateTime.Today.Year) ? 
            DateTime.Today.Year-BirthDate.Year-1 : 
            DateTime.Today.Year-BirthDate.Year;
    }
    public int GetExperience()
    {
        return EmploymentDate > DateTime.Today.AddYears(EmploymentDate.Year - DateTime.Today.Year) ? 
            DateTime.Today.Year-EmploymentDate.Year-1 : 
            DateTime.Today.Year-EmploymentDate.Year;
    }
    public void RiseSalary (double premium)
    {
        Salary += premium;
    }
}