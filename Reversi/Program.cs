internal class Program
{
    private static void Main(string[] args)
    {
        char[,] field = new char[,]{
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','W','B','.','.','.','.'},
            {'.','.','B','W','.','.','.','.'},
            {'.','W','.','B','W','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'}};
        MainField temp = new MainField();
        char[,] res = temp.FindTheMoves(field, 'W');
        Console.WriteLine();
        Console.WriteLine();
        for (int a = 0; a < 8; ++a)
        {
            for (int b = 0; b < 8; ++b)
            {
                Console.Write($"{res[a, b]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}