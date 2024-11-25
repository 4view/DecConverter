namespace Dcalc.Tests.Core;

public class HexConverterTests
{
    [Theory]
    [InlineData("787", "313")]
    [InlineData("1234","4D2")]
    [InlineData("1899","76B")]
    public void ToHex_DecimalInput_validHexExpression(string decimalExpression, string expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.FromDecimal(decimalExpression);

        //Assert
        Assert.Equal(expected, actual.Result);
    }

    [Theory]
    [InlineData("Hello", false)]
    [InlineData("", false)]
    [InlineData("       ", false)]
    [InlineData("!@#$%^&*()_", false)]
    public void ToHex_IsValidInput_ReturnFalse(string decimalExpression, bool expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.IsValidNumber(decimalExpression);

        //Assert
        Assert.Equal(expected, actual);
    }

    private ToHexConverter CreateConverter()
    {
        return new ToHexConverter();
    }
}