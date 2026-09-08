using AdAct.DAL.Contracts;

namespace AdAct.Entities;

/// <summary>
/// Акт приёма и передачи.
/// </summary>
public class AcceptanceAct : BaseAuditEntity
{
    /// <summary>
    /// Номер приложения.
    /// </summary>
    public string ApplicationNumber { get; set; } = string.Empty;

    /// <summary>
    /// Место составления акта.
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Дата составления акта.
    /// </summary>
    public DateTimeOffset ActDate { get; set; }

    /// <summary>
    /// Email Заказчика, на который отправлен макет.
    /// </summary>
    public string RecipientEmail { get; set; } = string.Empty;

    /// <summary>
    /// Страницы/ресурсы, где размещены макеты (Пункт 2 акта).
    /// </summary>
    public string PublishedOnPages { get; set; } = string.Empty;

    /// <summary>
    /// Внешний ключ Договора.
    /// </summary>
    public Guid ContractId { get; set; }
    public Contract Contract { get; set; } = null!;

    /// <summary>
    /// Внешний ключ Макетa.
    /// </summary>
    public Guid AdLayoutId { get; set; }
    public AdLayout AdLayout { get; set; } = null!;
}
