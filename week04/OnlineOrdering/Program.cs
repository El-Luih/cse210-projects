using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> order1List = [
            new Product("Pencil", 206, 0.49, 20),
            new Product("Eraser", 231, 0.99, 10),
            new Product("Scissors", 289, 2.99, 5),
            new Product("Sharpener", 220, 0.99, 5)
            ];
        List<Product> order2List = [
            new Product("Magnetic Marker Set", 776, 14.99, 3),
            new Product("Magnetic Whiteboard", 778, 66.80, 1),
            new Product("Folding White Cane", 789, 36.40, 1),
            new Product("Reading Glasses", 1023, 69.99, 1)
            ];
        List<Product> order3List = [
            new Product("Medium Backpack", 401, 74.99, 4),
            new Product("Metal Ring Notebook", 014, 7.99, 32),
            new Product("Small Pencil Case", 448, 16.99, 4)
            ];

        Order order1 = new Order(order1List,
        new Customer("Rena Zweystendelt",
        new Address("Marienplatz 8", "München", "Bavaria", "Germany")));
        Order order2 = new Order(order2List,
        new Customer("Lili Satou",
        new Address("437 Terao Yamaku Konpurekkusu-7-5", "Agatsuma-gun", "Gunma", "Japan")));
        Order order3 = new Order(order3List,
        new Customer("Nicole Amarfi",
        new Address("144 W Benteen St", "Buffalo", "Wyoming", "USA")));

        Console.Clear();
        Console.WriteLine($"{order1.PackingLabel()}{order1.ShippingLabel()}Total: {order1.TotalPrice()}$\n\n\n");
        Console.WriteLine($"{order2.PackingLabel()}{order2.ShippingLabel()}Total: {order2.TotalPrice()}$\n\n\n");
        Console.WriteLine($"{order3.PackingLabel()}{order3.ShippingLabel()}Total: {order3.TotalPrice()}$\n\n\n");
    }
}