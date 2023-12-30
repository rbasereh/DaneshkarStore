using Application.Common;
using Domain.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IAppDbContext _dbContext;

    public GetAllProductsQueryHandler(IAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var query = _dbContext.Product.AsQueryable();

        if (!string.IsNullOrEmpty(request.Name))
            query = query.Where(e => e.Name.Contains(request.Name));

        if (request.Status.HasValue)
            query = query.Where(e => e.Status == request.Status);

        var data = await query.ToListAsync();

        return data;
    }
}