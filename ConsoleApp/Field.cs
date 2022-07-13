namespace ConsoleApp;

class Field
{
    private int Size {get;set;} = 15;
    private Snake Snake {get;set;}
    private Food Food {get;set;}
    private Wall Walls {get;init;}

    public Field(int size, Snake snake, Wall walls)
    {
        Size = size;
        Snake = snake;
        Walls = walls;
        SpawnFood();
    }
    
    public void Render()
    {
        Walls.Render();
        Food.Render();
        Snake.Render(); 
    }

    public void Update()
    {
        if (Snake.IsEatingHimself() || Snake.IsHittingWall(Walls)) Environment.Exit(0);        
        if (Snake.IsEating(Food))
        {
            Snake.Grow(Food);
            SpawnFood();
        }
        Snake.Move();
    }
    
    public void SpawnFood()
    {
        var random = new Random((int)DateTime.Now.Ticks);
        List<Point> emptyPoints = new List<Point>();
        for (int x = 1; x<Size; x++)
        {
            for (int y = 1; y<Size; y++)
            {
                Point newPoint = new Point(x, y);
                if (!Snake.Contains(newPoint) && !Walls.Contains(newPoint))
                    emptyPoints.Add(newPoint);
            }   
        }    
        Food = new Food(emptyPoints[random.Next(0,emptyPoints.Count+1)]);
    }

}