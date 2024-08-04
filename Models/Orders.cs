namespace EMedicineBE.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }

        public List<Orders> listOrders { get; set; }

        public Orders order { get; set; } //creating a single object for order
        public List<OrderItems> listItems { get; set; }

        public OrderItems orderItem { get; set; } //creating a single object for order item




    }
}
