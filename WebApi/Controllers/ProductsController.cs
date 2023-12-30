using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;
using Domain.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task CreateProduct(CreateProductCommand command)
        {
            await mediator.Send(command);
        }

        [HttpGet]
        public async Task<List<Product>> GetAll([FromQuery] GetAllProductsQuery query)
        {
            var response = await mediator.Send(query);
            return response;
        }
    }
}
