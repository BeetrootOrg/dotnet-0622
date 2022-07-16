using System.Threading;

using ConsoleApp;

var gameMenu = new GameMenu();
gameMenu.Run();

Thread.Sleep(Timeout.Infinite);