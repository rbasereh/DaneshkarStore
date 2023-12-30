using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Application.Common
{
    public interface IAppDbContext 
    {
        DbSet<Product> Product { get; set; }
        DbSet<Order> Order { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
