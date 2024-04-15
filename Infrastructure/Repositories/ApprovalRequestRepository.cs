using System;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class ApprovalRequestRepository : IApprovalRequestRepository
    {
        private readonly ProductManagementDbContext _dbContext;

        public ApprovalRequestRepository(ProductManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ApprovalRequest>> GetApprovalRequestsAsync()
        {
            return await _dbContext.ApprovalRequests
                .OrderByDescending(ar => ar.RequestDate)
                .ToListAsync();
        }
    }
}

