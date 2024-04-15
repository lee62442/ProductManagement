using ApplicationCore.Entities;
using System;

namespace ApplicationCore.ServiceInterfaces
{
	public interface IApprovalRequestService
	{
        Task AddApprovalRequestAsync(ApprovalRequest approvalRequest);
    }
}

