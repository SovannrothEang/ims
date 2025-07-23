namespace api.Endpoints.Products.DeleteProduct;

public class DeleteProductEndpoint
{
    public static IResult Handle(int id)
    {
        return Results.Ok($"Delete product with id: {id}");
    }
}
