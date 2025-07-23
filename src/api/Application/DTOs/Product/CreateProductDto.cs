namespace api.Application.DTOs.Product;

public class CreateProductDto(
    string name,
    string sku,
    string? description,
    string unit,
    double price,
    int quantity,
    Guid? categoryId
) : ProductDto(name, sku, description, unit, price, quantity, categoryId)
{}
