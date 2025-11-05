using IceScream.Models.Enums;

namespace IceScream;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Ice Scream!");
        Console.WriteLine("---------------");
        Console.WriteLine("Is this a \"Dine in\" or \"Takeout\" order?");
        var orderType = Console.ReadLine();
        // check to make sure customer picks a valid order type
        try
        {
            var orderEnum = (OrderEnum)Enum.Parse(typeof(OrderEnum), orderType.Replace(" ", ""), true);
            orderType = orderEnum.ToString();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter \"Dine in\" or \"Takeout\".");
            return;
        }
        Console.WriteLine($"Thank you! Your order is {orderType}.");
        Console.WriteLine("What flavor would you like?");
        Console.WriteLine("Options: Witch's Brew Berry, Graveyard Chocolate Crunch, Ghosty Vanilla, Mummy's Cookies & Cream, Dracula's Kiss");
        var flavor = Console.ReadLine();
        // Check to make sure customer picks a valid flavor
        Console.WriteLine($"Great choice! You selected {flavor} flavor.");
        Console.WriteLine("How many scoops would you like?");
        var scoopsInput = Console.ReadLine();
        int scoops;
        try
        {
            scoops = int.Parse(scoopsInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for scoops.");
            return;
        }

        Console.WriteLine($"You have ordered {scoops} scoops of {flavor} ice cream for {orderType}.");
        Console.WriteLine("Would you like your ice cream in a waffle cone or a cup?");
        var container = Console.ReadLine();
        Console.WriteLine($"You have chosen a {container} for your ice cream.");
        Console.WriteLine($"Thank you for your order! Enjoy your ice cream!");
    }
}
