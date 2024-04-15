using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infrastructure.Repositories
{
	public class ProductRepository : IProductRepository
    {
        private readonly ProductManagementDbContext _dbContext;

		public ProductRepository(ProductManagementDbContext dbContext)
		{
            _dbContext = dbContext;
		}

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _dbContext.Products.Where(p => p.Id == id).FirstAsync();
        }

        public async Task<IEnumerable<Product>> GetActiveProductsAsync()
        {
            return await _dbContext.Products
                .Where(p => p.IsActive)
                .OrderByDescending(p => p.PostedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(string productName, double? minPrice, double? maxPrice, DateTime? startDate, DateTime? endDate)
        {
            var query = _dbContext.Products.AsQueryable();

            if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(p => p.Name.Contains(productName));
            }

            if (minPrice.HasValue)
            {
                query = query.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= maxPrice.Value);
            }
            if (startDate.HasValue)
            {
                query = query.Where(p => p.PostedDate >= startDate.Value.Date);
            }
            if (endDate.HasValue)
            {
                query = query.Where(p => p.PostedDate <= endDate.Value.Date);
            }

            return await query.OrderByDescending(p => p.PostedDate).ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            if (!product.IsActive)
            {
                await AddApprovalRequestAsync(product.Id, RequestType.Create, "Creation with Price Over $5000"); 
            }

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (!product.IsActive)
            {
                await AddApprovalRequestAsync(product.Id, RequestType.Update, "Updating Product Price");
            }

            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product product)
        {
            product.IsActive = false;
            await AddApprovalRequestAsync(product.Id, RequestType.Delete, "Delete Product");
        }

        public async Task AddApprovalRequestAsync(int productId, RequestType requestType, string requestReason)
        {
            var approvalRequest = new ApprovalRequest
            {
                ProductId = productId,
                RequestReason = requestReason,
                RequestDate = DateTime.Now,
                RequestType = requestType
            };
            _dbContext.ApprovalRequests.Add(approvalRequest);
            await _dbContext.SaveChangesAsync();

        }

        private async Task RejectRequestAsync(ApprovalRequest approvalRequest)
        {
            approvalRequest.Status = ApprovalStatus.Rejected;
            _dbContext.ApprovalRequests.Remove(approvalRequest);
            await _dbContext.SaveChangesAsync();
        }

        private async Task ApproveRequestAsync(ApprovalRequest approvalRequest)
        {
            approvalRequest.Status = ApprovalStatus.Approved;
            var product = approvalRequest.Product;

            if (approvalRequest.RequestType == RequestType.Delete)
            {
                _dbContext.Products.Remove(product!);
            }
            else if (approvalRequest.RequestType == RequestType.Update)
            {
                _dbContext.Products.Update(product!);
                
            } else
            {
                _dbContext.Products.Add(product!);
            }

            _dbContext.ApprovalRequests.Remove(approvalRequest);
            await _dbContext.SaveChangesAsync();

        }
    }
}

