// See https://aka.ms/new-console-template for more information

using Pattern_PROXY;

IChief chief = new ChiefProxy(new Chief());

while (true)
{
    Thread.Sleep(2000);
    Console.Clear();

    Console.WriteLine("  WELCOME TO COOKER!!!\n");
    Console.WriteLine("==========orders=========\n");

    IEnumerable<Order> orders = chief.GetOrders();
    foreach (Order order in orders)
    {
        string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

        Console.WriteLine($"{order.Name}\t\t{status}" );
    }
}
