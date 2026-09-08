using AdAct.DAL.Contracts;

namespace AdAct.Entities;

/// <summary>
/// Договор, к кторому привязан акт.
/// </summary>
public class Contract : BaseAuditEntity
{
    /// <summary>
    /// Номер договора.
    /// </summary>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Дата заключения.
    /// </summary>
    public DateTimeOffset ContractDate { get; set; }

    /// <summary>
    /// Внешний ключ Заказчика.
    /// </summary>
    public Guid CustomerId { get; set; }
    public Counterparty Customer { get; set; } = null!;

    /// <summary>
    /// Внешний ключ Исполнителя.
    /// </summary>
    public Guid ExecutorId { get; set; }
    public Counterparty Executor { get; set; } = null!;
}
