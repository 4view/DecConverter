using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

namespace Dcalc.Core.Convertion;

public class ToHexConverter : IConverter
{
    public int NumericBase { get; } = 16; 

    public ConvertationResult FromDecimal(string decimalExpression)
    {
        if (decimalExpression == null)
            return ConvertationResult.CreateError("expression can not be empty");

        StringBuilder hexExpression = new StringBuilder();
        int userExpression = int.Parse(decimalExpression);
        int temp = 0;

        while (userExpression > 0)
        {
            temp = userExpression % 16;
            userExpression = userExpression / 16;

            if (temp == 10)
                hexExpression.Append("A");
            else if (temp == 11)
                hexExpression.Append("B");
            else if (temp == 12)
                hexExpression.Append("C");
            else if (temp == 13)
                hexExpression.Append("D");
            else if (temp == 14)
                hexExpression.Append("E");
            else if (temp == 15)
                hexExpression.Append("F");
            else 
                hexExpression.Append(temp);            
        }

        var result = string.Join("", hexExpression.ToString().Reverse());
        return ConvertationResult.CreateSuccess(result);
    }

    public bool IsValidNumber(string number) =>
        int.TryParse(number, out int result); 
    
}