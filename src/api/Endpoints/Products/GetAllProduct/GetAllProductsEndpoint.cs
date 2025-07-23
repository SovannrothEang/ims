using api.Infrastructure;

namespace api.Endpoints.Products.GetAllProduct;

public class GetAllProductsEndpoint
{
    public static IResult Handle(
    )
    {
        var result = "Get all products";
        return Results.Ok(result);
    } 
}
