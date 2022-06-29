using ConsoleApp.School;

var person1 = new Person { FistrName = "Samson", LastName = "Butler", DateOfBirth = new DateTime(1996, 01, 12) };
var person2 = new Person { FistrName = "Yaqub ", LastName = "Wilson", DateOfBirth = new DateTime(1986, 04, 14) };

var person3 = new Person { FistrName = "Luis", LastName = "Kelly", DateOfBirth = new DateTime(1965, 11, 12) };
var person4 = new Person { FistrName = "Elias ", LastName = "Rogers", DateOfBirth = new DateTime(1994, 10, 12) };
var person5 = new Person { FistrName = "Yoel ", LastName = "Bennett", DateOfBirth = new DateTime(1996, 06, 12) };

var person6 = new Person { FistrName = "Ignacio ", LastName = "Scott", DateOfBirth = new DateTime(1996, 10, 12) };
var person7 = new Person { FistrName = "Brock ", LastName = "Howard", DateOfBirth = new DateTime(1977, 10, 12) };
var person8 = new Person { FistrName = "Remington ", LastName = "Howard", DateOfBirth = new DateTime(1994, 01, 11) };
var person9 = new Person { FistrName = "Milo ", LastName = "Adams", DateOfBirth = new DateTime(1930, 04, 12) };

var teacher1 = new Teacher
{
    TeacherInfo = person1,
    Salary = 1500,
    SubjectThatTeaches = Subject.History
};

var teacher2 = new Teacher
{
    TeacherInfo = person2,
    Salary = 2200,
    SubjectThatTeaches = Subject.Geography
};

var teacher3 = new Teacher
{
    TeacherInfo = person3,
    Salary = 1700,
    SubjectThatTeaches = Subject.History
};



var student1 = new Student
{
    Scholarhip = 700,
    StudentInfo = person4
};

var student2 = new Student
{
    Scholarhip = 900,
    StudentInfo = person5
};

var student3 = new Student
{
    Scholarhip = 450,
    StudentInfo = person6
};
var student4 = new Student
{
    Scholarhip = 300,
    StudentInfo = person7
};
var student5 = new Student
{
    Scholarhip = 200,
    StudentInfo = person8
};
var student6 = new Student
{
    Scholarhip = 500,
    StudentInfo = person9
};




var schoolClass1 = new[]
{
    new  SchoolClass
    {
        ClassTeacher = teacher1,
        ClasslLevel = SchoolLevels.ElementarySchool,
        ClassStudents = new[]{student1,student2}
    }
};

var schoolClass2 = new[]
{
    new  SchoolClass
    {
        ClassTeacher = teacher2,
        ClasslLevel = SchoolLevels.HighSchool,
        ClassStudents = new[]{student3,student4}
    }
};

var schoolClass3 = new[]
{
    new  SchoolClass
    {
        ClassTeacher = teacher3,
        ClasslLevel = SchoolLevels.HighSchool,
        ClassStudents = new[]{student5,student6}
    }
};


var elemSchool = new ElementarySchool { ElementarySchoolClass = schoolClass1, NameClass = "7-B" };
var secondSchool = new SecondarySchool { SecondarySchoolClass = schoolClass2, NameClass = "9-A" };
var highSchool = new HighSchool { HighSchoolClass = schoolClass3, NameClass = "11-D" };



