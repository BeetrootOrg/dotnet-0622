class SchoolClass
{
    public Student[] Pupils { get; set; }
    public Teacher Teacher { get; set; }

    public SchoolClass(Student[] pupils, Teacher teacher)
    {
        Pupils = pupils;
        Teacher = teacher;
    }
}