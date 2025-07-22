using api.Endpoints.Products.CreateProduct;
using api.Endpoints.Products.GetAllProduct;

namespace api.Endpoints.Products;

public static class ProductEndpoints
{
    public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder builder)
    {
        var products = builder.MapGroup("/products")
            .WithTags("Products");
        products.MapGet("/", GetAllProductsEndpoint.Handle)
            .WithName("Get all products");
        products.MapPost("/", CreateProductEndpoint.Handle)
            .WithName("Create product");

        return builder;
    }
}
