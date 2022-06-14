﻿/*
 1) що таке метод:
  це частина коду яка має певне імя, і виконує пувну дію. якщо метод повертає результат своєї роботи то це функція а іначкш еце посуті процедура
  щоб метод нічого не поверта потрібно перед його назвою вказати параметр void -посуті вказавши цим самим що це процедура
  метод має може мати параметри які в ього будуть передані з іншої частини програми, а можна і без параметрів. загалом складається з сигнатури(назва і параметри) і 
  тіла(це сам його ко який буде виконуватися всередині метода)

 2) навіщо він взагалі потрібен 
  частіше для того щоб не писати однакові частини коду в різних місця для виконання однотипних дій. 
  написали метод один раз і в різних частинах просто його викликаємо з різними параметрами для того щоб він виконав дію і повернув результат.
*/

//як оголосити метод
static void HelloWord()
{
    System.Console.WriteLine("HelloWorld");
}
// і ось як викликати цей метод HelloWord - просто написати його імя. в даному випадку це посуті метод процедура(нічого не повертає а просто відпрацьовує тіло методу), без параметрів також.
HelloWord();


// далі як викликати метод з параметрами і як він виглядає
static void HelloToSomeBody(string somebody)
{
    System.Console.WriteLine($"Hello, {somebody}");// така конструкція означає що до коми виведеться як текст посуті, а що після коми в дужках то посуті виведе значення змінної
    // результат виводу буде HelloDima якщо в змінній містилось Dima
}
// також оскільки метод цей всього одну строку в тілі виконує то його можна записати в іншому форматі 
// static void HelloToSomeBody(string somebody) => System.Console.WriteLine($"Hello, {somebody}"); // тут все те саме буде просто одною строкою

//і виклик цього методу HelloToSomebody з параметром в якому ми передамо просто слова Dima
HelloToSomeBody("Dima");

// ось приклад простого метода(функціі, тобото метод який поверне якийсь резуьтат своєї роботи)

static int Square(int x)
{
    return x * x; // return це ключове слово дл яфункціі яке означає повернути саме те що написано в цьому місці(тобто значення перемінної чи якоїсь інш дії)
   //або оголосити змінну і в неї записати значення множення а потім ретурну вказати цю змінну.
   
    
}

// і виклик цього метода з переданим в нього параметром який посуті наш метод має обрахувати
Square(3);// ось так просто викликаємо з параметром
System.Console.WriteLine(Square(3));// а соь так виклиємо його з параметром в середині вже іншої функціі

// ВАЖЛИВО. два приклади але в один ми передаємо змінну як value тип і а іншу як ref тип.
/*
тут різниця в тому що в add3 ми отримуемо не посилання на значення а саме значення і працюємо з ним в середині метода а за межами метода це значення ніяк не знімиться..
взяли initial = 5 дадали в методі 5+3 в методі стало 8 але за межами initial так і лишився дорівнювати 5
а в методі add5 ми передали вже initial як реф тип і тому за межами метода результат вже не буде 5 а стане 8, 5+3 = 8

*/
static void add3(int initial)
{
 initial += 3;
}

static void add5(ref int initial)
{
 initial += 3;
}

var initial = 5; //ми цю змінну передамо по різному тому вона після обробки матиме потім різне значення.
add3(initial);
add5(ref initial);


//перерка ділення на 3 без залишку.. так само можна перевірити ділення на будь-що(на 2 на 5 і тд)
static bool TryDivideBy3(int number, out int result)
{
    if (number % 3 == 0)
    {
    result = number / 3;
    return true;
    }
    
    result = 0;
    return false;
    
}

bool success;
success = TryDivideBy3(6, out initial);
System.Console.WriteLine($"Success:{success}. Result: {initial}");

success = TryDivideBy3(7, out initial);
System.Console.WriteLine($"Success:{success}. Result: {initial}");
