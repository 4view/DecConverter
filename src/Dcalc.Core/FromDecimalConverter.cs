using Dcalc.Core.Convertion;
using Microsoft.VisualBasic;

namespace Dcalc.Core;

public class FromDecimalConverter
{   
    private readonly List<IConverter> _converters;

    public FromDecimalConverter(List<IConverter> converters)
    {
        _converters = converters;
    }

    public ConvertationResult Convert(string userNumber, int numberSystem)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(userNumber);

        var userNumberSystem = _converters.First(c => c.NumericBase == numberSystem);
        var result = userNumberSystem.FromDecimal(userNumber);

        if (result == null)
            return ConvertationResult.CreateError("result is null");

        return result;
    }
}