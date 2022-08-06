namespace Snake.Console.Presenter.GameProcess;

class Field
{
    private int _size = 15;
    private int _score = 0;
    private Snake _snake;
    private Food _food;
    private Wall _walls;

    public Field()
    {
        _snake = new Snake();
        _walls = new Wall();
        SpawnFood();
    }

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
        RenderScore();
    }

    private void RenderScore()
    {
        ForegroundColor = ConsoleColor.White;
        SetCursorPosition(0, _size);
        Write($"Score: {_score}");
    }

    public bool Update()
    {
        if (_snake.IsEatingHimself() || _snake.IsHittingWall(_walls)) 
        {
            _snake.StopListening();
            return false;
        }        
        if (_snake.IsEating(_food))
        {
            _snake.Grow();
            SpawnFood();
            _score++;
        }
        _snake.Move();
        return true;
    }    
    
    private void SpawnFood()
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

    public int GetSize() => _size;
    public int GetScore() => _score;
}