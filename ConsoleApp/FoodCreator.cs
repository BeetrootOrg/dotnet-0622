namespace Snake;
class FoodCreator
{
    private int _mapWidht;
   private int _mapHeight;
   private char _sym;

    Random random = new Random();

    public FoodCreator(int mapWidht, int mapHeight, char sym)
    {
        _mapWidht = mapWidht;
        _mapHeight = mapHeight;
        _sym = sym;
    }

    public Point CreateFood()
    {
        int x = random.Next(2, _mapWidht - 2);
        int y = random.Next(2, _mapHeight - 2);
        return new Point(x, y, _sym);
    }
}
