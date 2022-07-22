Console.WindowHeight = 16;
Console.WindowWidth = 32;
int screenWidth = Console.WindowWidth;
int screenHeight = Console.WindowHeight;
Random random = new Random();
int score = 5;
int gameover = 0;
Pixel pixel = new Pixel();
pixel.xPos = screenWidth / 2;
pixel.yPos = screenHeight / 2;
pixel.colorHead = ConsoleColor.Red;
string movement = "RIGHT";
List<int> xPosList = new List<int>();
List<int> yPosList = new List<int>();
int foodX = random.Next(0, screenWidth);
int foodY = random.Next(0, screenHeight);
DateTime t1 = DateTime.Now;
DateTime t2 = DateTime.Now;
string buttonPressed = "no";
while (true)
{
    Console.Clear();
    if (pixel.xPos == screenWidth - 1 || pixel.xPos == 0 || pixel.yPos == screenHeight - 1 || pixel.yPos == 0)
    {
        gameover = 1;
    }
    for (int i = 0; i < screenWidth; i++)
    {
        Console.SetCursorPosition(i, 0);
        Console.Write(".");
    }
    for (int i = 0; i < screenWidth; i++)
    {
        Console.SetCursorPosition(i, screenHeight - 1);
        Console.Write(".");
    }
    for (int i = 0; i < screenHeight; i++)
    {
        Console.SetCursorPosition(0, i);
        Console.Write(".");
    }
    for (int i = 0; i < screenHeight; i++)
    {
        Console.SetCursorPosition(screenWidth - 1, i);
        Console.Write(".");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    if (foodX == pixel.xPos && foodY == pixel.yPos)
    {
        score++;
        foodX = random.Next(1, screenWidth - 2);
        foodY = random.Next(1, screenHeight - 2);
    }
    for (int i = 0; i < xPosList.Count(); i++)
    {
        Console.SetCursorPosition(xPosList[i], yPosList[i]);
        Console.Write("*");
        if (xPosList[i] == pixel.xPos && yPosList[i] == pixel.yPos)
        {
            gameover = 1;
        }
    }
    if (gameover == 1)
    {
        break;
    }
    Console.SetCursorPosition(pixel.xPos, pixel.yPos);
    Console.ForegroundColor = pixel.colorHead;
    Console.Write('*');
    Console.SetCursorPosition(foodX, foodY);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write('%');
    t1 = DateTime.Now;
    buttonPressed = "no";
    while (true)
    {
        t2 = DateTime.Now;
        if (t2.Subtract(t1).TotalMilliseconds > 500) { break; }
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo choise = Console.ReadKey(true);
            if (choise.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonPressed == "no")
            {
                movement = "UP";
                buttonPressed = "yes";
            }
            if (choise.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonPressed == "no")
            {
                movement = "DOWN";
                buttonPressed = "yes";
            }
            if (choise.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonPressed == "no")
            {
                movement = "LEFT";
                buttonPressed = "yes";
            }
            if (choise.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonPressed == "no")
            {
                movement = "RIGHT";
                buttonPressed = "yes";
            }
        }
    }
    xPosList.Add(pixel.xPos);
    yPosList.Add(pixel.yPos);
    switch (movement)
    {
        case "UP":
            pixel.yPos--;
            break;
        case "DOWN":
            pixel.yPos++;
            break;
        case "LEFT":
            pixel.xPos--;
            break;
        case "RIGHT":
            pixel.xPos++;
            break;
    }
    if (xPosList.Count() > score)
    {
        xPosList.RemoveAt(0);
        yPosList.RemoveAt(0);
    }
}
Console.SetCursorPosition(screenWidth / 5, screenHeight / 2);
Console.WriteLine("Game over, Score: " + score);
Console.SetCursorPosition(screenWidth / 5, screenHeight / 2 + 1);

Console.ReadKey();

class Pixel
{
    public int xPos { get; set; }
    public int yPos { get; set; }
    public ConsoleColor colorHead { get; set; }
}