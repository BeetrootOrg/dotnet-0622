using System.Numerics;

using BigNumberClass = ConsoleApp.BigNumber;

namespace BigNumber.Tests;

public class BigNumberTests
{
    [Theory]
    [InlineData("0", "0")]
    [InlineData("5", "0")]
    [InlineData("0", "44")]
    [InlineData("1", "2")]
    [InlineData("1", "1")]
    [InlineData("9", "9")]
    [InlineData("99", "9")]
    [InlineData("51", "52")]
    [InlineData("55", "56")]
    [InlineData("19999", "500")]
    [InlineData("99005200356444276279003530117327", "98054780144628813463682975933776")]
    [InlineData("67984968445323629970668402197973", "946451295676192883025574068570")]
    [InlineData("772479580521055299336715298460348230", "438657949257407650")]
    [InlineData("5", "-5")]
    [InlineData("-5", "5")]
    [InlineData("-5", "-5")]
    [InlineData("780563560949246206", "-201817972160438869")]
    [InlineData("-374700564182246584", "884920972940472617")]
    [InlineData("-4475015497379796428647604", "-3975344439807821794616946")]
    public void AddShouldPerformIt(string bn1, string bn2)
    {
        // Arrange
        var number1 = new BigNumberClass(bn1);
        var number2 = new BigNumberClass(bn2);

        var bigInt1 = BigInteger.Parse(bn1);
        var bigInt2 = BigInteger.Parse(bn2);

        // Act
        var result = number1 + number2;
        var expected = bigInt1 + bigInt2;

        // Assert
        Assert.Equal(expected.ToString(), result.ToString());
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("54", "0")]
    [InlineData("2", "1")]
    [InlineData("655", "655")]
    [InlineData("99", "9")]
    [InlineData("198", "99")]
    [InlineData("56", "55")]
    [InlineData("19999", "500")]
    [InlineData("99005200356444276279003530117327", "98054780144628813463682975933776")]
    [InlineData("67984968445323629970668402197973", "946451295676192883025574068570")]
    [InlineData("772479580521055299336715298460348230", "438657949257407650")]
    [InlineData("5", "-5")]
    [InlineData("-5", "5")]
    [InlineData("-5", "-5")]
    [InlineData("780563560949246206", "-201817972160438869")]
    [InlineData("-374700564182246584", "884920972940472617")]
    [InlineData("-4475015497379796428647604", "-3975344439807821794616946")]
    public void SubtractShouldPerformIt(string bn1, string bn2)
    {
        // Arrange
        var number1 = new BigNumberClass(bn1);
        var number2 = new BigNumberClass(bn2);

        var bigInt1 = BigInteger.Parse(bn1);
        var bigInt2 = BigInteger.Parse(bn2);

        // Act
        var result = number1 - number2;
        var expected = bigInt1 - bigInt2;

        // Assert
        Assert.Equal(expected.ToString(), result.ToString());
    }


    [Theory]
    [InlineData("0", "0")]
    [InlineData("1", "0")]
    [InlineData("2", "1")]
    [InlineData("100", "1000")]
    [InlineData("1234", "1234")]
    [InlineData("12", "34")]
    [InlineData("99005200356444276279003530117327", "98054780144628813463682975933776")]
    [InlineData("67984968445323629970668402197973", "946451295676192883025574068570")]
    [InlineData("772479580521055299336715298460348230", "438657949257407650")]
    [InlineData("5", "-5")]
    [InlineData("-5", "5")]
    [InlineData("-5", "-5")]
    [InlineData("780563560949246206", "-201817972160438869")]
    [InlineData("-374700564182246584", "884920972940472617")]
    [InlineData("-4475015497379796428647604", "-3975344439807821794616946")]
    public void MultiplyShouldPerformIt(string bn1, string bn2)
    {
        // Arrange
        var number1 = new BigNumberClass(bn1);
        var number2 = new BigNumberClass(bn2);

        var bigInt1 = BigInteger.Parse(bn1);
        var bigInt2 = BigInteger.Parse(bn2);

        // Act
        var result = number1 * number2;
        var expected = bigInt1 * bigInt2;

        // Assert
        Assert.Equal(expected.ToString(), result.ToString());
    }
}