using System;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
	public class ApprovalRequestService : IApprovalRequestService
    {
        private readonly IApprovalRequestRepository _repository;
		public ApprovalRequestService(IApprovalRequestRepository repository)
		{
            _repository = repository;
		}

        public async Task<IEnumerable<ApprovalRequestResponseModel>> GetActiveProductsAsync()
        {
            var requests =  await _repository.GetActiveProductsAsync();

            var requestModels = new List<ApprovalRequestResponseModel>();
            foreach(var request in requests)
            {
                requestModels.Add(new ApprovalRequestResponseModel
                {
                    ApprovalRequestId = request.ApprovalRequestId,
                    ProductId = request.ProductId,
                    RequestDate = request.RequestDate,
                    RequestReason = request.RequestReason,
                    RequestType = request.RequestType,
                    Status = request.Status,
                });
            }

            return requestModels;
        }
    }
}

