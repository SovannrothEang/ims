namespace api.Endpoints.Products.UpdateProduct;

public class UpdateProductEndpoint
{
    public static IResult Handle(int id)
    {
        return Results.Ok($"Update product with id: {id}");
    }
}
