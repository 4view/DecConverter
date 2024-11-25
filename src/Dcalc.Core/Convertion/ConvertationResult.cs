using System.Security.Cryptography.X509Certificates;
using Dcalc.Core.Common;

namespace Dcalc.Core.Convertion;

/// <summary>
/// Результат преобразования числа
/// </summary>
public class ConvertationResult : OperationResult
{
    /// <summary>
    /// Результат преобразования
    /// </summary>
    public string? Result { get; private set; }

    public static ConvertationResult CreateSuccess(string result)
    {
        return new ConvertationResult
        {
            Result = result,
            IsSuccess = true,
            ErrorMessage = null
        };
    }

    /// <summary>
    /// Создает объект, сигнализирующий об ошибке операции
    /// </summary>
    /// <param name="message">Сообщение об ошибке</param>
    public static ConvertationResult CreateError(string message)
    {
        return new ConvertationResult
        {
            Result = null,
            IsSuccess = false,
            ErrorMessage = message 
        };
    }
    
}