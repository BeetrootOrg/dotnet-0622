using System;

using Shouldly;

using Xunit.Abstractions;

namespace GameOfLife.Tests;

public class GameOfLifeTests
{
    private readonly ITestOutputHelper _output;

    public GameOfLifeTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Theory]
    [InlineData(new string[0], new string[0])]
    [InlineData(new[] { "." }, new[] { "." })]
    [InlineData(new[] { ".." }, new[] { ".." })]
    [InlineData(new[] { "***" }, new[] { ".*." })]
    [InlineData(new[] { "..*", ".**" }, new[] { ".**", ".**" })]
    [InlineData(new[] { ".....", "..*..", "..*..", "..*..", "....." }, new[] { ".....", ".....", ".***.", ".....", "....." })]
    [InlineData(new[] { "*..", "*..", "*..", "*.." }, new[] { "...", "**.", "**.", "..." })]
    [InlineData(new[] { "**", "..", "..", ".." }, new[] { "..", "..", "..", ".." })]
    [InlineData(new[] { "****", "****", "****", "****" }, new[] { "*..*", "....", "....", "*..*" })]
    [InlineData(new[] { "**...", "*....", ".....", "....*", "...**" }, new[] { "**...", "**...", ".....", "...**", "...**" })]
    [InlineData(new[] { "**...", "**...", ".....", "...**", "...**" }, new[] { "**...", "**...", ".....", "...**", "...**" })]
    [InlineData(new[] { "**...", "**...", "..*..", "...**", "...**" }, new[] { "**...", "*.*..", ".***.", "..*.*", "...**" })]
    [InlineData(new[] { "**...", "*.*..", ".***.", "..*.*", "...**" }, new[] { "**...", "*..*.", ".....", ".*..*", "...**" })]
    [InlineData(new[] { "**...", "*..*.", ".....", ".*..*", "...**" }, new[] { "**...", "**...", ".....", "...**", "...**" })]
    public void Test1(string[] input, string[] expected)
    {
        // Arrange
        var newLineTab = $"{Environment.NewLine}\t";
        var cellsInput = FromStrings(input);
        var cellsExpected = FromStrings(expected);

        // Act
        _output.WriteLine(string.Join(newLineTab, input));
        var result = new GameOfLife().Execute(cellsInput);

        // Assert
        _output.WriteLine($"{newLineTab}{string.Join(newLineTab, ToStrings(result))}");
        result.ShouldBe(cellsExpected);
    }

    private static char[,] FromStrings(string[] strings)
    {
        if (strings.Length == 0)
        {
            return new char[0, 0];
        }

        var cells = new char[strings.Length, strings[0].Length];
        for (var i = 0; i < strings.Length; ++i)
        {
            for (var j = 0; j < strings[i].Length; ++j)
            {
                cells[i, j] = strings[i][j];
            }
        }

        return cells;
    }

    private static string[] ToStrings(char[,] cells)
    {
        var dim1 = cells.GetLength(0);
        var dim2 = cells.GetLength(1);

        var result = new string[dim1];
        for (var i = 0; i < dim1; ++i)
        {
            result[i] = string.Empty;
            for (var j = 0; j < dim2; ++j)
            {
                result[i] += cells[i, j];
            }
        }

        return result;
    }
}