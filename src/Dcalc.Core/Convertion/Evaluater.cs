using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Dcalc.Core.Convertion;

public class Evaluater
{
    public string Evaluate(int userExpression, int numberSystem, int temp)
    {
        StringBuilder result = new StringBuilder();

        while (userExpression > 0)
        {
            temp = userExpression % numberSystem;
            userExpression = userExpression / numberSystem;

            result.Append(temp);
        }
        return result.ToString();
    }
}