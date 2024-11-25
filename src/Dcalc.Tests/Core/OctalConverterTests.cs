namespace Dcalc.Tests.Core;

public class ConverterTests
{
    [Theory]
    [InlineData("100","144")]
    [InlineData("550","1046")]
    [InlineData("1269","2365")]
    public void ToOctal_DecimalInput_ValidOctalExpression(string decimalExpression, string expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.FromDecimal(decimalExpression);

        //Assert
        Assert.Equal(expected, actual.Result);
    }

    [Theory]
    [InlineData("GOOOO", false)]
    [InlineData("", false)]
    [InlineData("       ", false)]
    [InlineData("!№;%1:?*431()", false)]
    public void ToOctal_IsValidInput_ReturnFalse(string decimalExpression, bool expected)
    {
        //Arrange
        var converter = CreateConverter();

        //Act
        var actual = converter.IsValidNumber(decimalExpression);
        
        //Assert
        Assert.Equal(expected, actual);
    }

    private ToOctalConverter CreateConverter()
    {
        return new ToOctalConverter();
    }
}