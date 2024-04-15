using System;
namespace ApplicationCore.Models
{
	public class ProductResponseModel
	{
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public double ProductPrice { get; set; }

        public DateTime PostedDate { get; set; }

        public Boolean IsActive { get; set; }
    }
}

