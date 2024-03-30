using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceApis.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
