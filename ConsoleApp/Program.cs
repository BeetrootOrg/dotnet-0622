
     
int[] MyArray = { 25, 0, 90, -5, 3 }; // declare array
int tempValue; 
var MyCopyArr = new int[MyArray.Length];// then copy 
Array.Copy(MyArray, MyCopyArr, MyArray.Length);
 
 for (int j = 0; j <= MyCopyArr.Length - 2; ++j) 
    {
       for (int i = 0; i <= MyCopyArr.Length - 2; ++i) 
       {
        if (MyCopyArr[i] > MyCopyArr[i + 1]) 
           {
            tempValue= MyCopyArr[i + 1];
            MyCopyArr[i + 1] = MyCopyArr[i];
            MyCopyArr[i] = tempValue;
            }
       }
    }
Console.WriteLine("------ result ----- ");
foreach (int ichSortedElement in MyCopyArr)
System.Console.WriteLine(ichSortedElement);

//Console.Read();
