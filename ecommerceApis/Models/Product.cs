namespace ecommerceApis.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Pricing { get; set; }
        public decimal ShippingCost { get; set; }
    }
}
