using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Products.CreateProduct;

public class CreateProductEndpoint
{
    public record CreateProductRequest(
        string Name,
        string SKU,
        string? Description,
        string Unit,
        double Price,
        int Quantity
        // Guid CategoryId
    );
    public static IResult Handle(
        CreateProductRequest request
    )
    {
        var result = $"Name: {request.Name}, SKU: {request.SKU}, Description: {request.Description}, ";
        result += $"Unit: {request.Unit}, Price: {request.Price}, Quantity: {request.Quantity}";
        return Results.Ok(result);
    }
}
