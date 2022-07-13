namespace ConsoleApp;

class Field
{
    private int _size = 15;
    private Snake _snake;
    private Food _food;
    private Wall _walls;

    public Field(int size, Snake snake, Wall walls)
    {
        _size = size;
        _snake = snake;
        _walls = walls;
        SpawnFood();
    }

    public void Render()
    {
        _walls.Render();
        _food.Render();
        _snake.Render(); 
    }

    public void Update()
    {
        if (_snake.IsEatingHimself() || _snake.IsHittingWall(_walls)) Environment.Exit(0);        
        if (_snake.IsEating(_food))
        {
            _snake.Grow();
            SpawnFood();
        }
        _snake.Move();
    }
    
    public void SpawnFood()
    {
        var random = new Random((int)DateTime.Now.Ticks);
        List<Point> emptyPoints = new List<Point>();
        for (int x = 0; x<_size; x++)
        {
            for (int y = 0; y<_size; y++)
            {
                Point newPoint = new Point(x, y);
                if (!_snake.Contains(newPoint) && !_walls.Contains(newPoint))
                    emptyPoints.Add(newPoint);
            }   
        }    
        _food = new Food(emptyPoints[random.Next(0,emptyPoints.Count)]);
    }

}