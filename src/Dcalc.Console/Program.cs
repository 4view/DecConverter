using System.Security.Cryptography.X509Certificates;
using Dcalc.Core;
using Dcalc.Core.Convertion;

public class Program
{
    static void Main(string[] args)
    {
        var converters = new List<IConverter>();
        var binConverter = new ToBinaryConverter();
        var octalConverter = new ToOctalConverter();
        var hexConverter = new ToHexConverter();

        converters.AddRange([binConverter, octalConverter, hexConverter]);

        FromDecimalConverter operation = new FromDecimalConverter(converters);

        Console.Write("Enter your number: ");
        var userNumber = Console.ReadLine();

        Console.Write("what system number to convert: (2, 8 or 16): ");
        int numberSystem = int.Parse(Console.ReadLine());

        var result = operation.Convert(userNumber, numberSystem);

        Console.WriteLine(result.Result);        

    }
}