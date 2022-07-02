namespace ConsoleApp.SOLID;

class BarbaraLiskovParentBad
{
    public int Number() => 1;
}

class BarbaraLiskovChildBad : BarbaraLiskovParentBad
{
    public new int Number() => 2;
}

class BarbaraLiskovBad
{
    void Main()
    {
        BarbaraLiskovParentBad bad = new BarbaraLiskovChildBad();
        System.Console.WriteLine(bad.Number()); // output 1 instead of 2
    }
}

class BarbaraLiskovParentBest
{
    public virtual int Number() => 1;
}

class BarbaraLiskovChildBest : BarbaraLiskovParentBest
{
    public override int Number() => 2;
}

class BarbaraLiskovBest
{
    void Main()
    {
        BarbaraLiskovParentBad bad = new BarbaraLiskovChildBad();
        System.Console.WriteLine(bad.Number()); // output 2
    }
}