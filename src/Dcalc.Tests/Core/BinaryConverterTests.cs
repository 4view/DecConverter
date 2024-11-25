namespace Dcalc.Tests.Core;

[Trait("category", "toBin")]
public class BinaryConverterTests
{
    [Theory]
    [InlineData("10", "1010")]
    [InlineData("103", "1100111")]
    [InlineData("150", "10010110")]
    public void ToBinary_DecimalInput_ValidBinaryExpression(string decimalExpression, string expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.FromDecimal(decimalExpression);

        //Assert
        Assert.Equal(expected, actual.Result);
    }

    [Theory]
    [InlineData("Helllo", false)]
    [InlineData("", false)]
    [InlineData("         ", false)]
    [InlineData("!№;%:?*()=-09_", false)]
    public void ToBinary_IsValidInput_ReturnFalse(string decimalExpression, bool expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.IsValidNumber(decimalExpression);

        //Assert
        Assert.Equal(expected, actual);
    }

    private ToBinaryConverter CreateConverter()
    {
        return new ToBinaryConverter();
    }
}