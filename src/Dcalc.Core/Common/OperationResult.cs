namespace Dcalc.Core.Common;

/// <summary>
/// Результат выполнения некой операции
/// </summary>
public class OperationResult
{
    /// <summary>
    /// Индикатор успешности операции
    /// </summary>
    public bool IsSuccess { get; protected set; }

    /// <summary>
    /// Сообщение об ошибке, если операция была не успешна
    /// </summary>
    public string? ErrorMessage { get; protected set; }
}