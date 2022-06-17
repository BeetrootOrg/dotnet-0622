internal class Program
{
    static bool Compare (string str1, string str2)
    {
        return str1.GetHashCode() == str2.GetHashCode();
    }
                   
    static void Main(string[] args)
    {
        string string1 ="SOme excellent string here";
        string string2 ="SOme excellent string here";
        Console.WriteLine(Compare (string1, string2));


    }    
      
}