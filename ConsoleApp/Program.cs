System.Console.Write("Enter your text: ");
var text = Console.ReadLine();
System.Console.Write("Enter count: ");
int num = Convert.ToInt32(Console.ReadLine());
WR(num,text);

static void WR(int num, string text)
{
    if (num >= 0)  System.Console.WriteLine("");
    System.Console.WriteLine(text);
    WR(num -1,text);
}

