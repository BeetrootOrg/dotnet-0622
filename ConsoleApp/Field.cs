namespace ConsoleApp;

class Field
{
    public Snake Snake { get; init; }
    public Food Food { get; set; }
    public int Size { get; init; } = 15;

    public void IsCollision()
    {

        int j = 0;
        int snakeLenght = Snake.Body.Count();
        var head = Snake.Body.Last();

        foreach (var point in Snake.Body)
        {   
            if (++j != snakeLenght && point.X == head.X && point.Y == head.Y)
            {
                throw new ("You Ate your tail! Game Over!");
            }

            if(head.X == Size || head.Y == Size || head.X == 0 || head.Y == 0 )
                throw new ("You hit the border! Game Over!");
        
            if (head.X == Food.Position.X && head.Y == Food.Position.Y)
                {
                    Snake.IsFoodEated = true;
                    bool foodOnSnake = false;

                    Food newFood;
                    do {
                    
                        newFood = new Food(Size);
                        
                        foreach (var subPoint in Snake.Body)
                        {
                            if (newFood.Position.X == subPoint.X && newFood.Position.Y == subPoint.Y)
                            {
                                foodOnSnake = true; 
                                break;
                            } 
                        }
                    } while (foodOnSnake);

                    Food = newFood;
                    // System.Console.WriteLine($"New Food, X: {Food.Position.X}, Y: {Food.Position.Y}");
                    //    System.Console.ReadKey();
                    //throw new ($"You ate the Food! The snake length now is {Snake.Body.Count()} ");
                }
        }


    }
}

