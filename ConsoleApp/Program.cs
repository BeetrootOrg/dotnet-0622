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
        
        Reversi reversi = new Reversi();
        reversi.WriteArray(input);
        Console.WriteLine();
        reversi.WriteArray(reversi.Calculate(input, 'B'));
    }
}