using AdAct.DAL.Contracts;

namespace AdAct.Entities;

/// <summary>
/// Контрагент (Заказчик или Испольнитель).
/// </summary>
public class Counterparty : BaseAuditEntity
{
    /// <summary>
    /// Название организации или ФИО.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// В лице кого (должность).
    /// </summary>
    public string RepresentedBy { get; set; } = string.Empty;

    /// <summary>
    /// На оновании чего действует.
    /// </summary>
    public string ActingOnBasisOf { get; set; } = string.Empty;
}
