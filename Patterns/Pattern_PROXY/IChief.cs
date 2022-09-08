namespace Pattern_PROXY;
public interface IChief
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();
}
