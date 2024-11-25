namespace Dcalc.Core.Convertion;

/// <summary>
/// Интерфейс, который конвертирует число 
/// </summary>
public interface IConverter
{
    /// <summary>
    /// Конвертирует число в определенную систему счисления 
    /// </summary>
    /// <returns>Строку в определенной системе счисления</returns>
    public ConvertationResult FromDecimal(string decimalExpression);

    /// <summary>
    /// Определяет принадлежность к той или иной системе счисления
    /// </summary>
    public int NumericBase { get; }
}