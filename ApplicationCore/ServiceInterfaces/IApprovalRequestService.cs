using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;

namespace ApplicationCore.ServiceInterfaces
{
	public interface IApprovalRequestService
	{
        Task<IEnumerable<ApprovalRequestResponseModel>> GetActiveProductsAsync();
    }
}

