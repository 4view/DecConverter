namespace Dcalc.Core.Convertion;

/// <summary>
/// Класс для конвертации в двоичную систему счисления
/// </summary>
public class ToBinaryConverter : IConverter
{
    public int NumericBase { get; } = 2;

    public ConvertationResult FromDecimal(string decimalExpression)
    {
        if (string.IsNullOrWhiteSpace(decimalExpression))
            return ConvertationResult.CreateError("Expression can not be empty");

        Evaluater evaluater = new Evaluater();
        int userExpression = int.Parse(decimalExpression);
        var temp = 0;
    
        var binaryExpression = evaluater.Evaluate(userExpression, numberSystem: 2, temp);        

        var result = string.Join("", binaryExpression.ToString().Reverse());
        return ConvertationResult.CreateSuccess(result);
    }

    public bool IsValidNumber(string number) =>
        int.TryParse(number, out int result);
        
}