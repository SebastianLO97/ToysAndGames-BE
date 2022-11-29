using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ToysAndGames.DTOs;

namespace ToysAndGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(_productService.GetProducts()));
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProductById([FromRoute] int id)
        {
            return Ok(_mapper.Map<ProductDTO>(_productService.GetProductById(id)));
        }

        [HttpPost]
        public ActionResult<ProductDTO> CreateProduct([FromBody] Product product)
        {
            return Ok(_mapper.Map<ProductDTO>(_productService.CreateProduct(product)));
        }

        [HttpPut]
        public ActionResult<ProductDTO> UpdateProduct([FromBody] Product product)
        {
            return Ok(_mapper.Map<ProductDTO>(_productService.UpdateProduct(product)));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct([FromRoute] int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}