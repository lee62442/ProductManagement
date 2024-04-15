using System;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
	public interface IApprovalRequestRepository
	{
        Task AddApprovalRequestAsync(ApprovalRequest approvalRequest);
    }
}

