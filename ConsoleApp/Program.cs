﻿
     
int[] MyArray = { 25, 0, 90, -5, 3, 11 }; // declare array
int tempValue; 
var MyCopyArr = new int[MyArray.Length];// then copy 
Array.Copy(MyArray, MyCopyArr, MyArray.Length);// then copy
 
 for (int j = 0; j <= MyCopyArr.Length - 2; ++j) 
    {
       for (int i = 0; i <= MyCopyArr.Length - 2; ++i) 
       {
        if (MyCopyArr[i] > MyCopyArr[i + 1]) //если значение текущей ячейки больше чем значение со следующей ячейки 
           {                                 //тогда мы начинаем их переставлять местами.. 
            tempValue= MyCopyArr[i + 1];     //меньшее значение запишем в темповую переменную   
            MyCopyArr[i + 1] = MyCopyArr[i]; //потом в следующую ячейку запишем значение из текущей
            MyCopyArr[i] = tempValue;        //а в текущую запишем меньшее значение (которое до этого было в следующей ячейке)
                                             //таким образом мы поменяем местами значения в двух ячейках 
            }
       }
    }
Console.WriteLine("------ result ----- ");
foreach (int ichSortedElement in MyCopyArr)
System.Console.WriteLine(ichSortedElement);


