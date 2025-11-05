using IceScream.Models.Enums;

namespace IceScream.Models
{
    public class Order
    {
        public OrderEnum OrderType { get; set; }
        public MenuItem[] MenuItems { get; set; } = Array.Empty<MenuItem>();
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
    }

    
}
