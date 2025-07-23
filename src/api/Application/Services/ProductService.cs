using System.Threading.Tasks;
using api.Application.DTOs.Product;
using api.Application.Interfaces;
using api.Domain.Entities;
using api.Infrastructure.Interfaces;

namespace api.Application.Services;

public class ProductService(
    IProductRepository productRepositoyry
) : IProductService
{
    public async Task<IEnumerable<Product>> GetAll(CancellationToken ct)
    {
        return await productRepositoyry.GetAll(ct);
    }

    public async Task<Product?> GetOne(Guid id, CancellationToken ct)
    {
        return await productRepositoyry.GetOne(id, ct);
    }

    public Product Create(CreateProductDto productDto, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public bool Update(Guid id,UpdateProductDto productDto, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
