using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

public abstract class BaseEntity
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }
    [Column("is_deleted")]
    public bool IsDeleted { get; set; } = false;
}
