using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_products")]
public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Unit { get; set; } = "pcs";
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public Guid UserId { get; set; }
    public required User User { get; set; }
}
