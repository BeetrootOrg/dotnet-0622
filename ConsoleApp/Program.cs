/*Create a program that will start with declaration of two constants (X and Y) and will count the sum of all numbers between these constants. 
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
//Example 1


//int x = 0, y = 0;

int namber1 = 0, namber2 = 0; // распарсеные значения которые ввел юзер на первый и второй ответ
int sum = 0; // сума значений между числами которые ввел юзер
int countTimes = 0; // количество итераций цикла которое посути равно разнице между значениями которые ввел юзер
bool number1Correct = false; // если юзер ввел коректно ответ на первый вопрос то проставим 1 в эту переменную.
bool number2Correct = false; // если юзер ввел коректно ответ на второй вопрос то проставим 1 в эту переменную.
bool correctAnswer = false; // усли оба ответа были коректны то эту переменную поставим в 1, это означает что юзер не балван и можно перейти к вычислению суммы


// задаем юзеру первый вопрос, считываем его и получаем ответ и проверям коректно он ввел или нет, если корректно то ставим number1Correct=1, и запоминаем ответ
System.Console.WriteLine("Input number X");
var answer1 = System.Console.ReadLine();
//var x = int.Parse(answer1);
if (int.TryParse(answer1, out namber1))
{
    //x == namber1;
    number1Correct = true;
    System.Console.WriteLine("Браво, первое число ввели верно");
}


// задаем юзеру второй вопрос, считываем его и получаем ответ и проверям коректно он ввел или нет, если корректно то ставим number2Correct=1, и запоминаем ответ
System.Console.WriteLine("Input namber Y");
var answer2 = System.Console.ReadLine();
//var y = int.Parse(answer2);
if (int.TryParse(answer2, out namber2))
{
    //y == namber2;
    number2Correct = true;
    System.Console.WriteLine("Браво, второе число ввели верно");
}

// проверяем дал ли юзер 2 коректных ответа и если таки да, тогда ставим признак correctAnswer = 1;
if (number1Correct == true && number2Correct == true)
{
    correctAnswer = true;
    System.Console.WriteLine("вы ввели ответы верно, сейчас просчитаем результат");
}
else
{
   System.Console.WriteLine("ошибка ввода целого числа"); 
}


if (namber1 < namber2 && correctAnswer ) // сюда попадаем если первая меньше второй
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

else if  (namber1 > namber2 && correctAnswer) //сюда если вторая меньше первой
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


else if (namber1 == namber2 && correctAnswer) // сюда зайдем если  обе одинаковые и просто выводим значение любой из переменных
{
    System.Console.WriteLine($"одинаковые: {namber1}");
}

else // сюда заходим если полная дичь творится и шлем всех лесом за дичь
{
    System.Console.WriteLine("Всем спасибо все свободны");
}
//------------------------------------------------
