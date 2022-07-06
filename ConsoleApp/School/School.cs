namespace School;

class School
{
    public string Name {get;set;}
    public string Address {get;set;}
    public string PhoneNumber {get;set;}
    public string Email {get;set;}
    public Teacher[] Teachers {get;set;}
    public Pupil[] Pupils {get;set;}
    public SchoolClass[] SchoolClasses {get;set;}

    public void AddPupil (Pupil newPupil)
    {
        Pupil[] buffer = new Pupil[Pupils.Length+1];
        Pupils.CopyTo(buffer, 0);
        buffer[buffer.Length] = newPupil;
        Pupils = buffer;
    }
}