namespace Snake;
class Walls
{
   private List<Figure> _wallList;

    public Walls(int mapWidth, int mapHeight)
    {
        _wallList = new List<Figure>();

        HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
        HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
        VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
        VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

        _wallList.Add(upLine);
        _wallList.Add(downLine);
        _wallList.Add(leftLine);
        _wallList.Add(rightLine);
    }

    public bool IsHit(Figure figure)
    {
        foreach (var wall in _wallList)
        {
            if (wall.IsHit(figure))
            {
                return true;
            }
        }
        return false;
    }
    public void Draw()
    {
        foreach (var wall in _wallList)
        {
            wall.Draw();
        }
    }
}
