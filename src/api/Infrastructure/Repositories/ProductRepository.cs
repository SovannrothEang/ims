using System.Threading.Tasks;
using api.Application.DTOs.Product;
using api.Domain.Entities;
using api.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Repositories;

public class ProductRepository(
    AppDbContext context
) : IProductRepository
{
    public async Task<IEnumerable<Product>> GetAll(CancellationToken ct)
    {
        try
        {
            return await context.Products
                .AsNoTracking()
                .ToListAsync(cancellationToken: ct);
        }
        catch (Exception ex)
        {
            // throw new Exception("")
            return [];
        }
    }

    public async Task<Product?> GetOne(Guid id, CancellationToken ct)
    {
        return await context.Products
            .AsNoTracking()
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync(cancellationToken: ct);
    }

    public Product Create(CreateProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public bool Update(Guid id, UpdateProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
