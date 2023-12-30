using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
