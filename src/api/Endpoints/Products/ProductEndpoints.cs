using api.Endpoints.Products.CreateProduct;
using api.Endpoints.Products.DeleteProduct;
using api.Endpoints.Products.GetAllProduct;
using api.Endpoints.Products.GetProduct;
using api.Endpoints.Products.UpdateProduct;

namespace api.Endpoints.Products;

public static class ProductEndpoints
{
    public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder builder)
    {
        var products = builder.MapGroup("/products")
            .WithTags("Products");
        products.MapGet("/", GetAllProductsEndpoint.Handle)
            .WithName("Get all products");
        products.MapGet("/{id}", GetProductEndpoint.Handle)
            .WithName("Get product by id");
        products.MapPost("/", CreateProductEndpoint.Handle)
            .WithName("Create product");
        products.MapPut("/{id}", UpdateProductEndpoint.Handle)
            .WithName("Update product with id");
        products.MapDelete("/{id}", DeleteProductEndpoint.Handle)
            .WithName("Delete product with id");
        return builder;
    }
}
