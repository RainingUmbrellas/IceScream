using IceScream.Models.Enums;

namespace IceScream.Models
{
    public class MenuItem
    {
        public IceCreamFlavorEnum IceCreamFlavor { get; set; }
        // 1 scoop : 3.00
        // 2 scoops: 5.00
        public int Scoops { get; set; }
        public ContainerEnum ContainerType { get; set; }
        public ToppingsEnum Toppings { get; set; }
    }
}