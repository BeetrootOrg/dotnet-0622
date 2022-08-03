internal class Program
{
    private static void Main(string[] args)
    {
        char[,] born = new char[,]
        {
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '*', '.', '.', '.', '.', '.', '.'},
            {'*', '*', '*', '*', '*', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.'},

        };
        if (born.Rank == 2)
        {
            for (int a = 0; a < born.GetLength(0); ++a)
            {
                Console.WriteLine();
                for (int b = 0; b < born.GetLength(1); ++b)
                {
                    Console.Write(born[a, b]);
                }
            }

            var action = new GameOfLife();
            int z = 35;
            while (z > 0)
            {
                born = action.Execute(born);
                Console.WriteLine();
                Console.WriteLine();
                for (int a = 0; a < born.GetLength(0); ++a)
                {
                    Console.WriteLine();
                    for (int b = 0; b < born.GetLength(1); ++b)
                    {
                        Console.Write(born[a, b]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                --z;
            }
        }
    }
}