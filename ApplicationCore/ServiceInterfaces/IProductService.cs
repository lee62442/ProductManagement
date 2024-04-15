using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
	public interface IProductService
	{
		Task<Product> GetProductByIdAsync(int id);
		Task<IEnumerable<ProductResponseModel>> GetActiveProductsAsync();
        Task<IEnumerable<ProductResponseModel>> SearchProductsAsync(string productName, double? minPrice, double? maxPrice, DateTime? startDate, DateTime? endDate);
		Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);
    }
}

