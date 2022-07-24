using System.Linq;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class GameField
{
    public Snake Snake { get; init; }
    public Food Food
    {
        get => _food;
        init => _food = value;
    }

    public FieldBorder FieldBorder { get; init; }

    private Food _food;

    public IConsumable MoveSnake(Direction direction)
    {
        Snake.Move(direction);

        if (_food.SamePosition(Snake))
        {
            var oldFood = _food;
            Snake.Eat(oldFood);
            Food newFood;

            do
            {
                newFood = Food.Random(FieldBorder.Size);
            } while (oldFood.SamePosition(newFood) || Snake.SamePosition(newFood));

            _food = newFood;
            return oldFood;
        }

        if (FieldBorder.SamePosition(Snake))
        {
            Snake.Eat(FieldBorder);
            return FieldBorder;
        }

        var snakeHead = Snake.Head;
        var snakeBody = Snake.Body.FirstOrDefault(bp => snakeHead.SamePosition(bp));
        if (snakeBody != null)
        {
            Snake.Eat(snakeBody);
            return snakeBody;
        }

        return null;
    }
}