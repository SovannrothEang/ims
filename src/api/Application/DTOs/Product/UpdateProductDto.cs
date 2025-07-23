using System.ComponentModel.DataAnnotations;

namespace api.Application.DTOs.Product;

public class UpdateProductDto
{
    [Required(ErrorMessage = "Product ID is required for update.")]
    public Guid Id { get; set; }

    [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
    public string? Name { get; set; }
    [MaxLength(255, ErrorMessage = "SKU cannot exceed 255 characters.")]
    public string? SKU { get; set; }
    public string? Description { get; set; }
    public string? Unit { get; set; }
    [Range(0.01, double.MaxValue, ErrorMessage = "Invalid price")]
    public double? Price { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Invalid quantity. Quantity must be positive.")]
    public int? Quantity { get; set; }
    public Guid? CategoryId { get; set; }
}
