using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_categories")]
public class Category : BaseEntity
{
    [Column("name")]
    public string Name { get; set; } = string.Empty;
    [Column("user_id")]
    public Guid UserId { get; set; }
    public required User User { get; set; }
    public ICollection<Product> Products { get; set; } = [];
}
