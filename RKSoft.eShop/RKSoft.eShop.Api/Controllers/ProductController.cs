using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RKSoft.eShop.App.DTOs;
using RKSoft.eShop.App.Interfaces;
using RKSoft.eShop.Domain.Entities;

namespace RKSoft.eShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("all", Name = "GetAllProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAllProducts()
        {
            var Products = await _productService.GetAllProductAsync();
            var ProductsDTOdata = _mapper.Map<List<ProductDto>>(Products);

            return Ok(ProductsDTOdata);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetProductById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var Product = await _productService.GetProductByIdAsync(Product => Product.Id == id);
            if (Product == null) return NotFound($"The Product with id {id} not found");

            var ProductDtodata = _mapper.Map<ProductDto>(Product);
            return Ok(ProductDtodata);
        }

        [HttpPost]
        [Route("add", Name = "CreateProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDto dto)
        {
            if (dto == null) return BadRequest();

            Product Product = _mapper.Map<Product>(dto);
            var ProductAfterCreation = await _productService.CreateProductAsync(Product);

            dto.Id = ProductAfterCreation.Id;
            return CreatedAtRoute(nameof(GetProductById), new { id = dto.Id }, dto);
        }

        [HttpPut]
        [Route("update", Name = "UpdatProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UpdatProduct(ProductDto dto)
        {
            if (dto == null) return BadRequest();

            var newRecord = _mapper.Map<Product>(dto);

            await _productService.UpdateProductAsync(newRecord);
            return Ok(newRecord);
        }

        [HttpDelete]
        [Route("{id:int}/delete", Name = "DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var Product = await _productService.GetProductByIdAsync(Product => Product.Id == id);
            if (Product == null)
                return BadRequest($"The Product with Id {id} not found");
            var result = await _productService.DeleteProductAsync(Product);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
