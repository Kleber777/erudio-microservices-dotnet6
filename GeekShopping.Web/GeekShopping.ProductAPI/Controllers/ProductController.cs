using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using GeekShopping.ProductAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        
        [HttpGet]
        [Authorize()]
        public async Task<ActionResult<IEnumerable<ProductsVO>>> GetAll()
        {
            var products = await _repository.FindAll();
            
            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize()]
        public async Task<ActionResult<ProductsVO>> Get(long id)
        {
            var product = await _repository.FindById(id);
            if (product.Id <= 0)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        [Authorize()]
        public async Task<ActionResult<ProductsVO>> Create([FromBody] ProductsVO vo)
        {
            if (vo == null)
                return BadRequest();

            var product = await _repository.Create(vo);
            return Ok(product);
        }

        [HttpPut]
        [Authorize()]
        public async Task<ActionResult<ProductsVO>> Update([FromBody] ProductsVO vo)
        {
            if (vo == null)
                return BadRequest();

            var product = await _repository.Update(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Role.ADMIN)]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);

            if (!status)
                return BadRequest();

            return Ok(status);
        }

    }
}
