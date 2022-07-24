using System;

using ConsoleApp;

const int Size = 15;

var gameField = new GameField
{
    Food = Food.Random(Size),
    Snake = Snake.Create(),
    FieldBorder = new FieldBorder
    {
        Size = Size
    }
};

var renderer = new Renderer
{
    GameField = gameField
};

renderer.Init();

var controller = new Game
{
    Renderer = renderer
};

controller.StartGame();

while (true)
{
    var key = Console.ReadKey(false);
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            controller.Direction = Direction.Up;
            break;
        case ConsoleKey.DownArrow:
            controller.Direction = Direction.Down;
            break;
        case ConsoleKey.LeftArrow:
            controller.Direction = Direction.Left;
            break;
        case ConsoleKey.RightArrow:
            controller.Direction = Direction.Right;
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}