namespace api.Application.DTOs.Product;

public class ResponseProductDto(
    Guid id,
    string name,
    string sku,
    string? description,
    string unit,
    double price,
    int quantity,
    Guid? categoryId,
    Guid userId,
    DateTime createdAt,
    DateTime? updatedAt
    ) : ProductDto(name, sku, description, unit, price, quantity, categoryId)
{
    public Guid Id { get; set; } = id;
    public Guid UserId { get; set; } = userId;
    public DateTime CreatedAt { get; set; } = createdAt;
    public DateTime? UpdatedAt { get; set; } = updatedAt;
}
