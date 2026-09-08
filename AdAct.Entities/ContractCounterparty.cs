using AdAct.DAL.Contracts;

namespace AdAct.Entities;

/// <summary>
/// Связь Договора и Контрагента с указанием его роли.
/// </summary>
public class ContractCounterparty : BaseAuditEntity
{
    /// <summary>
    /// Внешний ключ договора.
    /// </summary>
    public Guid ContractId { get; set; }
    public Contract Contract { get; set; } = null!;

    /// <summary>
    /// Внешний ключ контрагента.
    /// </summary>
    public Guid CounterpartyId { get; set; }
    public Counterparty Counterparty { get; set; } = null!;

    /// <summary>
    /// Роль (Заказчик / Исполнитель)
    /// </summary>
    public CounterpartyRole Role { get; set; }
}
