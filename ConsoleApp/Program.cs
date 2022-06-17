public class Program
{

    static int myMin(int a, int b)=>  a <= b ? a : b;
    static int myMin(int a, int b, int c) => a <= b ? a <= c ? a : c : (b < c ? b : c);
    static int myMin(int a, int b, int c, int d) => a <= b ? a <= c ? a <= d ? a : d : (c <= d ? c : d) : (b < c ? b < d ? b : d : (d < c ? d : c)); 

    static int myMax(int a, int b)=> a > b ? a : b;
    static int myMax(int a, int b, int c)=> a >= b ? a >= c ? a : c : (b > c ? b : c);
    static int myMax(int a, int b, int c, int d) => a >= b ? a >= c ? a >= d ? a : d : (c > d ? c : d) : (b > c ? b > d ? b : d : (c > d ? c : d));


    static bool TrySumIfOdd(int a, int b, out int sum)
    {
        sum = 0;
        for(int i = myMin(a,b); i <= myMax(a,b); ++i)
        {
            sum += i;
        }

        return (sum % 2) != 0 ? true : false; 
    }


    static string Repeat1(string str, int count)
    {
        string repeater = str;
        while(count > 1)
        {
            count--;
            str += repeater;
            
        }

        return str;
    }

    static string RepeatRec(string str, int count, out string outStr)
    {
        outStr = "";
        if(count <= 0) return outStr;
        RepeatRec(str, count - 1, out outStr);
        return outStr += str;
    }   
    static void Main()
    {

        bool b = TrySumIfOdd(1,1, out int sum);
        Console.WriteLine(b);
        Console.WriteLine(sum);
        b = TrySumIfOdd(1,3, out sum);
        Console.WriteLine(b);
        Console.WriteLine(sum);
        Console.WriteLine(Repeat1("str", 8));
        RepeatRec("str",8,out string str);
        Console.WriteLine(str);

    }
}