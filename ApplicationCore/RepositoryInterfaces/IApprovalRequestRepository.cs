using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.RepositoryInterfaces
{
	public interface IApprovalRequestRepository
	{
        Task<IEnumerable<ApprovalRequest>> GetApprovalRequestsAsync();
    }
}

