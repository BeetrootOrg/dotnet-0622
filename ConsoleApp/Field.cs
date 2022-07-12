namespace ConsoleApp;

class Field
{
    public int Size {get;set;} = 15;
    public Snake Snake {get;set;}
    public Food Food {get;set;}
    public Wall Walls {get;init;}
    
}