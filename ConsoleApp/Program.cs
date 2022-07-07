namespace ConsoleApp;

class Prgram {

    public static void Main()
    {
        char[,] input = new char[8,8] { {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','B','W','.','.','.'},
                                        {'.','.','.','W','B','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'} };
        
        Reversi.WriteArray(input);
        Console.WriteLine();
        Reversi.WriteArray(Reversi.Calculate(input, 'B'));
    }
}