using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.RepositoryInterfaces
{
	public interface IProductRepository
	{
        // Get Product By Id
        Task<Product> GetProductByIdAsync(int id);

        // Get the Active Product List
        Task<IEnumerable<Product>> GetActiveProductsAsync();

        // Get search results for products by product name, price range, and posted date range
        Task<IEnumerable<Product>> SearchProductsAsync(string productName, double? minPrice, double? maxPrice, DateTime? startDate, DateTime? endDate);

        Task AddProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task DeleteProductAsync(Product product);

        Task AddApprovalRequestAsync(int productId, RequestType requestType, string requestReason);

    }
}

