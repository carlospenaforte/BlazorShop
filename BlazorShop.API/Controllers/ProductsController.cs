using BlazorShop.API.Mappings;
using BlazorShop.API.Repositories;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepositorie _productRepositorie;

        public ProductsController(IProductRepositorie productRepositorie)
        {
            _productRepositorie = productRepositorie;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
        {
            try
            {
                var products = await _productRepositorie.GetItems();
                if (products is null)
                {
                    return NotFound();
                }
                else
                {
                    var productDTO = products.ConvertProductsToDTO();
                    return Ok(productDTO);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     $"Error retrieving data from the database: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItem(int id)
        {
            try
            {
                var product = await _productRepositorie.GetItem(id);
                if (product is null)
                {
                    return BadRequest("Error to locate the product");
                }
                else
                {
                    var productDTO = product.ConvertProductToDTO();
                    return Ok(productDTO);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     $"Error retrieving data from the database: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("GetItemsCategory/{categoryId}")] 
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItemsCategory(int categoryId)
        {
            try
            {
                var products = await _productRepositorie.GetItemsCategory(categoryId);
                var productsDTO = products.ConvertProductsToDTO();
                return Ok(productsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     $"Error retrieving data from the database: {ex.Message}");
            }
        }
    }
}
