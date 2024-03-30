using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceApis.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
