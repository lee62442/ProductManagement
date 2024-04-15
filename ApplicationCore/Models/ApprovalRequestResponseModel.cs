using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Models
{
	public class ApprovalRequestResponseModel
	{
        public int ApprovalRequestId { get; set; }

        public int ProductId { get; set; }

        public DateTime RequestDate { get; set; }

        public string RequestReason { get; set; } = string.Empty;

        public RequestType RequestType { get; set; }

        public ApprovalStatus Status { get; set; }
    }
}

