using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_categories")]
public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = [];
    public Guid UserId { get; set; }
    public required User User { get; set; }
}
