using ConsoleApp.SchoolDomain;
namespace ConsoleApp;
partial class Program
{
    static void Main ()
    {
        School windzor = new School ("Windzor Elementary", "10 Levinski Street","winzorselem@gmail.com", "110077", 10);
        School central = new School ("Cental Gymnasium", "13 Williams Street", "gymnasiumcentral@gmail.com", "100800", 23);
        School [] schools = {windzor, central};

        Teacher mayers = new Teacher ("Joseline", "Mayers", Subject.Chemistry, 28);
        Teacher jones = new Teacher ("Bridgitte", "Jones", Subject.Arts, 32);
        Teacher [] teachers = {mayers, jones};

        Student marek = new Student ("Marek", "Polish", 8, Level.ElementarySchool);
        Student ciesta = new Student ("Ciesta", "Black", 15, Level.HighSchool);
        Student [] students = {marek, ciesta};

    }
}