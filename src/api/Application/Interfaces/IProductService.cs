using api.Application.DTOs.Product;
using api.Domain.Entities;

namespace api.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAll(CancellationToken ct);
    Task<Product?> GetOne(Guid id, CancellationToken ct);
    Product Create(CreateProductDto productDto, CancellationToken ct);
    bool Update(Guid id, UpdateProductDto productDto, CancellationToken ct);
    bool Delete(Guid id, CancellationToken ct);
}
