namespace School;

class Pupil
{
    public string FirstName {get;init;}
    public string LastName {get;set;}
    private string HomeAddress {get;set;}
    private string Email {get;set;}
    private (string, string) ParentsPhoneNumbers {get;set;}
    private DateTime BirthDate {get;init;}
    public int GetAge()
    {
        return BirthDate > DateTime.Today.AddYears(BirthDate.Year - DateTime.Today.Year) ? 
            DateTime.Today.Year-BirthDate.Year-1 : 
            DateTime.Today.Year-BirthDate.Year;
    }
}