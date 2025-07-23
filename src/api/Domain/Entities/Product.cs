using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_products")]
public class Product : BaseEntity
{
    [Column("name")]
    [Required(ErrorMessage = "Product name is required.")]
    [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
    public string Name { get; set; } = string.Empty;

    [Column("sku")]
    [Required(ErrorMessage = "Product name is required.")]
    [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
    public string SKU { get; set; } = string.Empty;

    [Column("description")]
    public string? Description { get; set; }

    [Column("unit")]
    [Required(ErrorMessage = "Unit is required.")]
    public string Unit { get; set; } = "pcs";

    [Column("price")]
    [Required(ErrorMessage = "Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Invalid price")]
    public double Price { get; set; }

    [Column("quantity")]
    [Required(ErrorMessage = "Quantity is required.")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity must be 0 or positive number")]
    public int Quantity { get; set; }

    [Column("category_id")]
    [Required(ErrorMessage = "Category ID is required.")]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    [Column("user_id")]
    public Guid UserId { get; set; }
    public required User User { get; set; }
}
