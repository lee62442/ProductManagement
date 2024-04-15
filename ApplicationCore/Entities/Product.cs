using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Models;

namespace ApplicationCore.Entities
{
	[Table("Product")]
	public class Product
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		[MaxLength(64)]
		public string Name { get; set; } = string.Empty;

		public double Price { get; set; }

		public DateTime PostedDate { get; set; }

		public Boolean IsActive { get; set; } // Products in Approval Queue are inactive
	}
}

