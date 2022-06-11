﻿/*Create a program that will start with declaration of two constants (X and Y) and will count the sum of all numbers between these constants. 
If they are equal then sum should be one of them

Example:
--этот вариант если первая переменная меньше второй, тогда мы тут от меньшей считаем к большей.
X=10
Y=12
Sum=10+11+12=33

--этот вариант если первая переменная больше второй... в таком случае мы от второй переменной считаем вверх
X=5
Y=2
Sum=2+3+4+5=14

--этот вариант если обе одинаковые то мы прост овыводим в результат значение любуй их них
X=10
Y=10
Sum=10
*/


int namber1 = 0, namber2 = 0; // распарсеные значения ответов, которые ввел юзер на первый и второй вопрос
int sum = 0; // сума значений между числами, которые ввел юзер
int countTimes = 0; // количество итераций цикла, которое посути равно разнице между значениями, которые ввел юзер
bool number1Correct = false; // если юзер ввел корректно ответ на первый вопрос - то проставим true в эту переменную.
bool number2Correct = false; // если юзер ввел корректно ответ на второй вопрос - то проставим true в эту переменную.
bool correctAnswer = false; // если оба ответа были корректны - то эту переменную поставим в true, это означает, что юзер не балван и можно перейти к вычислению суммы


// задаем юзеру первый вопрос, считываем его и получаем ответ и проверям корректно он ввел первый ответ или нет, если корректно то ставим number1Correct=true, и запоминаем ответ
System.Console.WriteLine("Input number X");
var answer1 = System.Console.ReadLine();
if (int.TryParse(answer1, out namber1))
{
    number1Correct = true;
    System.Console.WriteLine("Браво, первое число ввели верно");
}


// задаем юзеру второй вопрос, считываем его и получаем ответ и проверям корректно он ввел второй ответ или нет, если корректно то ставим number2Correct=true, и запоминаем ответ
System.Console.WriteLine("Input namber Y");
var answer2 = System.Console.ReadLine();
if (int.TryParse(answer2, out namber2))
{
    number2Correct = true;
    System.Console.WriteLine("Браво, второе число ввели верно");
}

// проверяем дал ли юзер 2 корректных ответа и если таки да, тогда ставим признак correctAnswer = true;
if (number1Correct == true && number2Correct == true)
{
    correctAnswer = true;
    System.Console.WriteLine("Вы ввели ответы верно, сейчас просчитаем результат");
}
else // иначе выводим сообщение, что юзер ошибся при вводе целого числа
{
   System.Console.WriteLine("ошибка ввода целого числа"); 
}

// с этого места уже начинается просчет результата в зависимости от того больше первое второго или меньше или оба одинаковые, а также ввел ли юзер правильно оба числа
if (namber1 < namber2 && correctAnswer ) // сюда попадаем, если первая меньше второй и юзер ввел оба числа корректно
{
    System.Console.WriteLine("Первая меньше второй");
    countTimes = namber2 - namber1;
for (int i = 0; i <= countTimes; ++i)
{
    sum = sum + namber1;
    namber1 = namber1 + 1; 
}
 System.Console.WriteLine(sum);
}

else if  (namber1 > namber2 && correctAnswer) //сюда если вторая меньше первой и юзер ввел оба числа корректно
{
    System.Console.WriteLine("Первая больше второй");
    countTimes = namber1 - namber2;
for (int i = 0; i <= countTimes; ++i)
{
    sum = sum + namber2;
    namber2 = namber2 + 1; 
}
System.Console.WriteLine(sum);
}

else if (namber1 == namber2 && correctAnswer) // сюда зайдем если  оба числа одинаковые и юзер ввел оба числа корректно
{
    System.Console.WriteLine($"одинаковые: {namber1}");// и просто выводим значение любой из переменных
}

else // сюда заходим если полная дичь творится и шлем всех лесом за дичь(например некоректно ввел числа)
{
    System.Console.WriteLine("Всем спасибо, все свободны");
}
//------------------------------------------------
