using Application.Common;
using Domain.Products;
using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        public readonly IAppDbContext _dbContext;

        public CreateProductCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                throw new Exception("Name is requeired");
            }


            Product product = new()
            {
                Name = request.Name,
                Price = request.Price,
                Status = ProductStatus.Draft,
                CreatedOn = DateTime.UtcNow,
            };
            _dbContext.Product.Add(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
