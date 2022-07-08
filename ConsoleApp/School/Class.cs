namespace ConsoleApp.School;

class Class
{
    public Teacher HomeroomTeacher { get; set; }
    public Pupil[] Pupils { get; set; }
    public int NumberOfPupils
    {
        get
        {
            return Pupils.Length;
        }
    }

public void AddNewPupil(Pupil NewPupil)
{
    throw new NotImplementedException();
}
}