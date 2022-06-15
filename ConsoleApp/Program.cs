
int numb1, numb2;



static int MaxMath(int numb1, int numb2)
{
int result;
if ( numb1 > numb2 )
{
   result = numb1;
   
}

else
{
result = numb2;
}

return result;

}


 numb1 = int.Parse(Console.ReadLine());
 numb2 = int.Parse(Console.ReadLine());
 //MaxMath(numb1, numb2);

System.Console.WriteLine(MaxMath(numb1, numb2));