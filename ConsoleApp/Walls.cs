namespace ConsoleApp;

class Wall
{
    public List<Point> Walls {get;set;}
    public Wall()
    {
        Walls = new List<Point>();
        int size = 15;
        for(int i = 0; i<=size; i++)
        {
            Walls.Add(new Point{
                X= 0,
                Y= i
            });

            Walls.Add(new Point{
                X= size,
                Y= i
            });

            Walls.Add(new Point{
                X= i,
                Y= 0
            });

            Walls.Add(new Point{
                X= i,
                Y= size
            });
        }
    }
    
}