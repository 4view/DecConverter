using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Dcalc.Core.Convertion;

/// <summary>
/// Класс для конвертации в восьмиричную систему счисления
/// </summary>
public class ToOctalConverter : IConverter
{
    public int NumericBase { get; } = 8;

    public ConvertationResult FromDecimal(string decimalExpression)
    {
        if (decimalExpression == null)
            return ConvertationResult.CreateError("expression can not be empty");

        Evaluater evaluater = new Evaluater();
        int userExpression = int.Parse(decimalExpression);
        int temp = 0; 

        var octalExpression = evaluater.Evaluate(userExpression, 8, temp);

        var result = string.Join("", octalExpression.ToString().Reverse());        
        return ConvertationResult.CreateSuccess(result);
    }

    public bool IsValidNumber(string number) =>
        int.TryParse(number, out int result);
}