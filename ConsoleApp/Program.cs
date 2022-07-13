<<<<<<< HEAD
﻿using System.Threading;

using ConsoleApp;

const int Size = 15;

var snake = new Snake();
var food = Food.Random(Size);
var field = new Field
{
    Food = food,
    Size = Size,
    Snake = snake
};

var renderer = new Renderer
{
    Field = field
};

System.Console.Clear();
renderer.Show();
renderer.StartGame();

Thread.Sleep(Timeout.Infinite);
=======
﻿
>>>>>>> 57ac2d78065123921bf228991220ccd51a2c6685
