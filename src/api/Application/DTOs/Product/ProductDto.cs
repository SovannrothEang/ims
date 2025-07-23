using System.ComponentModel.DataAnnotations;

namespace api.Application.DTOs.Product;

public class ProductDto(
    string name,
    string sku,
    string? description,
    string unit,
    double price,
    int quantity,
    Guid? categoryId
)
{
    [Required(ErrorMessage = "Product name is required.")]
    [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
    public required string Name { get; set; } = name;
    [Required(ErrorMessage = "SKU is required.")]
    [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
    public required string SKU { get; set; } = sku;
    public string? Description { get; set; } = description;
    [Required(ErrorMessage = "Unit is required.")]
    public required string Unit { get; set; } = unit;
    [Required(ErrorMessage = "Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Invalid price")]
    public double Price { get; set; } = price;
    [Required(ErrorMessage = "Quantity is required.")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity must be 0 or positive number")]
    public int Quantity { get; set; } = quantity;
    [Required(ErrorMessage = "Category ID is required.")]
    public Guid? CategoryId { get; set; } = categoryId;
}
