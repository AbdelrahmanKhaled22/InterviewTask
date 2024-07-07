using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewTask.Models
{
    public class InvoiceDetails
    {
        [Key]
        public int lineNo { get; set; }
        public string productName { get; set; }

        [ForeignKey("unitNo")]
        public int unitNo { get; set; }
        public int price { get; set; }
        public decimal quantity { get; set; }
        public int total { get; set; }

        public DateTime expiryDate { get; set; }
    }
}
