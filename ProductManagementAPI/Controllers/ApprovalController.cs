using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    public class ApprovalController : Controller
	{
        private readonly IApprovalRequestService _approvalService;

        public ApprovalController(IApprovalRequestService approvalService)
		{
            _approvalService = approvalService;
        }

        /// <summary>
        /// Retrieves a list of active products sorted by the latest posted date
        /// </summary>
        /// <returns></returns>
        [HttpGet("active")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var approvalRequests = await _approvalService.GetActiveProductsAsync();

            if (!approvalRequests.Any())
            {
                return NotFound("No product found.");
            }
            return Ok(approvalRequests);
        }
    }
}

