
namespace Pattern_BUILDER.Burger;
public class BurgerProductBuilder : IBurgerProductBuilder
{
    private BurgerProduct _burgerProduct;
    private readonly IEnumerable<ProductFilling> _burgersFilling;
    public BurgerProductBuilder(IEnumerable<ProductFilling> burgersFilling)
    {
        _burgersFilling = burgersFilling;
        _burgerProduct = new ();
    }
    public IBurgerProductBuilder BuildTop()
    {
        Random random = new Random();
        var orderNumber = random.Next(1, 10);
        _burgerProduct.BurgerTop =
            $"\t  {DateTime.Now} \n\t BURGER  =>  Order N {orderNumber}\n\n\t\tBun \n";
        return this;
    }

    public IBurgerProductBuilder BuildFilling()
    {
        _burgerProduct.BurgerFilling =
            string.Join(Environment.NewLine,
            _burgersFilling.Select(s =>
            $"\t{s.LayersNumber} layers    of    {s.Name}"));
        return this;
    }

    public IBurgerProductBuilder BuildBase()
    {
        _burgerProduct.BurgerBase =
            $"\n\t\tBun\n\nThis burger consists of a bun and {_burgersFilling.Sum(e => e.LayersNumber) + 2} layers of filling";
        return this;
    }

    public BurgerProduct GetProduct()
    {
        BurgerProduct burgerProduct = _burgerProduct;
        _burgerProduct = new();
        return burgerProduct;
    }
}
