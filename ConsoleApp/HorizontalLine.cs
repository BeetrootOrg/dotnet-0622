namespace Snake;
class HorizontalLine : Figure
{
    public HorizontalLine(int xLeft, int xRight, int y, char sym)
    {
        PointList = new List<Point>();
        for (int x = xLeft; x <= xRight; x++)
        {
            Point p = new Point(x, y, sym);
            PointList.Add(p);
        }
    }
}
