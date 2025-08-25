using System.ComponentModel.DataAnnotations;

namespace Module
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public int stockQuantity { get; set; }
    }
    public class Cart
    {
        [Key]
        public int cart_id { get; set; }
        public int customer_id { get; set; }
        public int producy_id { get; set; }
        public int quantity { get; set; }
    }
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public DateTime order_date { get; set; }
        public int total_price { get; set; }
        public string shopping_address { get; set; }
    }
    public class Order_Item()
    {
        public int order_item_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }
}