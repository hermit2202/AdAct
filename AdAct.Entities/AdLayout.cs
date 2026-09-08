using AdAct.DAL.Contracts;

namespace AdAct.Entities;

/// <summary>
/// Свойства рекламного объявления.
/// </summary>
public class AdLayout : BaseAuditEntity
{
    /// <summary>
    /// Размеры макета.
    /// </summary>
    public string Dimensions { get; set; } = string.Empty;

    /// <summary>
    /// Вид носителя информации.
    /// </summary>
    public string MediaType { get; set; } = string.Empty;

    /// <summary>
    /// Тип макета.
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Веб-страница для размещения.
    /// </summary>
    public string TargetWebPage { get; set; } = string.Empty;

    /// <summary>
    /// Срок использования макета.
    /// </summary>
    public string UsagePeriod { get; set; } = string.Empty;
}
