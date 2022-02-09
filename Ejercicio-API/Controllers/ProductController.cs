using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ejercicio_API.Data;
using Ejercicio_API.Models;
using Ejercicio_API.Services;
using Ejercicio_API.Bl.Dto;

namespace Ejercicio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product, ProductDto>
    {
        public ProductController(IProductService productService) : base(productService)
        {

        }

        /*private readonly IBaseService<Product, ProductDto> _service;
         
        public ProductController(IBaseService<Product, ProductDto> service)
        {
            _service = service;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await _service.Get();
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            return await _service.Get(id);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDto product)
        {
            return await _service.Edit(id, product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostProduct(ProductDto product)
        {
            var CreatedProduct = await _service.Add(product);
            return CreatedAtAction("GetProduct", new { id = CreatedProduct.Id }, product);
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return await _service.Delete(id);
        }*/
    }
}
