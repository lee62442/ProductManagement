using System;
using ApplicationCore.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ApplicationCore.Entities
{
	[Table("ApprovalRequest")]
	public class ApprovalRequest
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApprovalRequestId { get; set; }

        // Foreign Key Property
        public int ProductId { get; set; }

        // Navigation Property
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public DateTime RequestDate { get; set; }

		public string RequestReason { get; set; } = string.Empty;

		public RequestType RequestType { get; set; }

        public ApprovalStatus Status { get; set; }
    }
}

