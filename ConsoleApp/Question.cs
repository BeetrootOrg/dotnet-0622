using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp;



class Question
{
    const string filenameQuestions = "questions.csv";
    const string filenameAnswer = "answer.csv";
    public string NameOfTopic;
    public string Answer;



    public void AddNewQuestion()
    {

        var questions = new List<string>();

        System.Console.WriteLine("Enter topic");
        NameOfTopic = System.Console.ReadLine();
        questions.Add(NameOfTopic);

        System.Console.WriteLine("Enter comma-setareted options");
        Answer = System.Console.ReadLine();
        questions.Add(NameOfTopic);
        
        string Serialize((string NameOfTopic, string Answer) row) => $"{row.NameOfTopic},{row.Answer}";
       // string Serialize((string NameOfTopic) row) => $"{row.NameOfTopic}";
       // File.AppendAllLines(filenameQuestions, new[] NameOfTopic);
       
        File.AppendAllLines(filenameAnswer, new[] { Serialize((NameOfTopic, Answer)) });

    }
    public void AddAnswears()
    {

    }


}