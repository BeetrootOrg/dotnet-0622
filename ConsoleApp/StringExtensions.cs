namespace ConsoleApp;

static class StringExtensions
{
    public static int CountWords(this string str)
    {
        return str.Split(new[] { ' ', ',', '.', ':', '?' }).Length;
    }

    public static int CountWords(this string str, string word)
    {
        return str.Split(word).Length - 1;
    }
}