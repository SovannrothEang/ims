namespace api.Endpoints.Products.GetProduct;

public class GetProductEndpoint
{
    public static IResult Handle(int id)
    {
        return Results.Ok($"Get Product by Id: {id}");
    }
}
