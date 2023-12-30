using Domain.Products;
using MediatR;

namespace Application.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<List<Product>>
{
    public string? Name { get; set; }
    public ProductStatus? Status { get; set; }
}
