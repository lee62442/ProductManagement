using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
	public class ProductService : IProductService
	{
        private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
            _productRepository = productRepository;
		}

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public async Task<IEnumerable<ProductResponseModel>> GetActiveProductsAsync()
        {
            var products = await _productRepository.GetActiveProductsAsync();
            return Mapping(products);

        }

        public async Task<IEnumerable<ProductResponseModel>> SearchProductsAsync(string productName, double? minPrice, double? maxPrice, DateTime? startDate, DateTime? endDate)
        {
            var products = await _productRepository.SearchProductsAsync(productName, minPrice, maxPrice, startDate, endDate);
            return Mapping(products);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
        }

        public async Task DeleteProductAsync(Product product)
        {
            await _productRepository.DeleteProductAsync(product);
        }


        // Mapping
        private IEnumerable<ProductResponseModel> Mapping(IEnumerable<Product> products)
        {

            var productResModel = new List<ProductResponseModel>();
            foreach (var product in products)
            {
                productResModel.Add(new ProductResponseModel
                {
                    Id = product.Id,
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    PostedDate = product.PostedDate,
                    IsActive = product.IsActive
                });
            }

            return productResModel;
            }
    }
}

