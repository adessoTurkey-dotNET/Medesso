using Medesso.Mediator;
using Medesso.Sample.Abstraction.Requests.Product;
using Medesso.Sample.Application.Product.Commands.CreateProduct;
using Medesso.Sample.Application.Product.Queries.GetProduct;
using Microsoft.AspNetCore.Mvc;

namespace Medesso.Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMedessoMediator _medessoMediator;

        public ProductsController(IMedessoMediator medessoMediator)
        {
            _medessoMediator = medessoMediator;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id, CancellationToken cancellationToken)
        {
            var query = new GetProductQuery(id);
            var result= await _medessoMediator.Send(query, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateProductCommand(request.Name, request.Description);
            var result= await _medessoMediator.Send(command, cancellationToken);
            return Ok(result);
        }
    }
}