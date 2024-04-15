using System;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Data
{
    public class DummyDataGenerator
    {
        List<Product> products = new List<Product>();
        List<ApprovalRequest> approvalQueue = new List<ApprovalRequest>();

        public void GenerateDummyData(int count)
        {
            Random random = new Random();
            string[] productNames = { "Widget", "Gadget", "Thingamajig", "Doohickey" };
            string[] requestReasons = { "New product", "Price change/Update request", "Delete request" };
            var approvalRequestId = 1;

            // Half products are active
            for (int i = 1; i <= count; i++)
            {
                var isActive = random.Next(2) == 0;
                Product product = new Product
                {
                    Id = i,
                    Name = productNames[random.Next(productNames.Length)] + " " + i,
                    Price = Math.Round((random.NextDouble() * 1000), 2), // Random price up to $1000
                    IsActive = isActive, // Randomly set IsActive to true or false
                    PostedDate = DateTime.Now.AddDays(-random.Next(1, 365)), // Random posted date within the last yea
                };

                // The other half are inactive, put in Approval Queue
                if (!isActive)
                {
                    var requestTypeId = random.Next(1, 4);
                    ApprovalRequest approvalRequest = new ApprovalRequest
                    {
                        ApprovalRequestId = approvalRequestId,
                        ProductId = product.Id,
                        RequestReason = requestReasons[requestTypeId - 1],
                        RequestDate = DateTime.Now.AddDays(-random.Next(1, 30)), // Random request date within the last 30 days
                        RequestType = (RequestType)requestTypeId, // Random request type for Create = 1, Update = 2, Delete = 3,
                        Status = ApprovalStatus.Pending
                    };

                    approvalQueue.Add(approvalRequest);
                    approvalRequestId++;
                }

                products.Add(product);
            }
        }

        public List<Product> GetDummyProducts()
        {
            return products;
        }


        public List<ApprovalRequest> GetDummyApprovalQueue()
        {
            return approvalQueue;
        }
    }
}

