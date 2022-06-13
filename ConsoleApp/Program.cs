System.Console.Write("Enter your text: ");
var text = Console.ReadLine();
System.Console.Write("Enter count: ");
var num = Console.ReadLine();
int.Parse(num);

static void WR(int a)
{
    
}

static string Repeat(string text, int count)
    {
        if (count <= 0) return "";
        return text + "\n" + Repeat(text, count - 1);
    }