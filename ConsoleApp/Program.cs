using System.Threading;

using ConsoleApp;

const int Size = 15;

var snake = new Snake();
var walls = new Wall();
var field = new Field(Size, snake, walls);

var snakeGame = new SnakeGame(field);

System.Console.Clear();
snakeGame.Show();
snakeGame.StartGame();

Thread.Sleep(Timeout.Infinite);