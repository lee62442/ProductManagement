using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IApprovalRequestService _approvalService;


        public ProductController(IProductService productService, IApprovalRequestService approvalService)
        {
            _productService = productService;
            _approvalService = approvalService;
        }

        /// <summary>
        /// Retrieve a Product By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        /// <summary>
        /// Retrieves a list of active products sorted by the latest posted date
        /// </summary>
        /// <returns></returns>
        [HttpGet("active")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productService.GetActiveProductsAsync();

            if (!products.Any())
            {
                return NotFound("No product found.");
            }
            return Ok(products);
        }

        /// <summary>
        /// Allows users to search for products by product name, price range, and posted date range.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Product>>> GetBySearch(
            [FromQuery] string productName,
            [FromQuery] double? minPrice,
            [FromQuery] double? maxPrice,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate)
        {
            var products = await _productService.SearchProductsAsync(productName, minPrice, maxPrice, startDate, endDate);
            if (!products.Any())
            {
                return NotFound("No product found.");
            }
            return Ok(products);
        }

       
        /// <summary>
        /// Allows the creation of a new product. Checks if the price is within the allowed range and automatically pushes products to the approval queue if necessary.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(
            [FromBody] ProductRequestModel request)
        {
            try {
                if (request == null)
                {
                    return BadRequest("Product data is not provided.");
                }

                // Validations
                if (request.Price > 10000)
                {
                    return BadRequest("Product price cannot exceed $10,000.");
                }

                // Create Product entity from request model
                var product = new Product
                {
                    Name = request.Name,
                    Price = request.Price,
                    IsActive = request.Price < 5000 ? true : false,
                    PostedDate = DateTime.Now,
                };

                // Add product to database
                await _productService.AddProductAsync(product);

                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{productId}")]
        public async Task<ActionResult<Product>> UpdateProduct(
            int productId,
            [FromBody] ProductRequestModel request)
        {
            try
            {
                // Check if the product ID is valid
                var existingProduct = await _productService.GetProductByIdAsync(productId);
                if (existingProduct == null)
                {
                    return NotFound("Product not found");
                }

                // Validate updated product data
                if (request == null)
                {
                    return BadRequest("Updated product data is not provided.");
                }

                // Update properties of existing product
                existingProduct.Name = request.Name;
                existingProduct.IsActive = (request.Price < 5000 && request.Price < existingProduct.Price*1.5) ? true : false;
                existingProduct.Price = request.Price;

                // Save changes to the database
                await _productService.UpdateProductAsync(existingProduct);

                return Ok(existingProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /* 

           * Delete Product:

           API Endpoint: DELETE /api/products/{productId}
           Description: Deletes a product. Moves the product to the approval queue before deletion.
           */

        [HttpDelete("{productId}")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            try
            {
                // Check if the product ID is valid
                var existingProduct = await _productService.GetProductByIdAsync(productId);
                if (existingProduct == null)
                {
                    return NotFound("Product not found");
                }

                // Delete the product
                await _productService.DeleteProductAsync(existingProduct);

                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}

