namespace Snake;
class Figure
{
    public List<Point> PointList;

    public void Draw()
    {
        foreach (Point p in PointList)
        {
            p.Draw();
        }
    }
    public bool IsHit(Figure figure)
    {
        foreach (var p in PointList)
        {
            if (figure.IsHit(p))
                return true;
        }
        return false;
    }
    public bool IsHit(Point point)
    {
        foreach (var p in PointList)
        {
            if (p.IsHit(point))
                return true;
        }
        return false;
    }
}
