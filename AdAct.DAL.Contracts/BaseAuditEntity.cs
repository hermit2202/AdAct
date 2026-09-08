namespace AdAct.DAL.Contracts;

/// <summary>
/// Базовый класс с аудитом.
/// </summary>
public class BaseAuditEntity
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// Кем создан.
    /// </summary>
    public string CreatedBy { get; set; } = string.Empty;

    /// <summary>
    /// Когда обнвлён.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Кем обнавлён.
    /// </summary>
    public string UpdatedBy { get; set; } = string.Empty;

    /// <summary>
    /// Дата удаления.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }
}
