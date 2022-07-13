using System.Threading;

using ConsoleApp;

const int Size = 15;

var snake = new Snake();
var walls = new Wall();
var field = new Field(Size, snake, walls);

var renderer = new Renderer
{
    Field = field
};

System.Console.Clear();
renderer.Show();
renderer.StartGame();

Thread.Sleep(Timeout.Infinite);