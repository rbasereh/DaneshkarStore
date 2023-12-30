using Domain.Products;

namespace Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
