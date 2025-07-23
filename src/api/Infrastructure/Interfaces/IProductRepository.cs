using api.Application.DTOs.Product;
using api.Domain.Entities;

namespace api.Infrastructure.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll(CancellationToken ct);
    Task<Product?> GetOne(Guid id, CancellationToken ct);
    Product Create(CreateProductDto productDto);
    bool Update(Guid id, UpdateProductDto productDto);
    bool Delete(Guid id);
}
