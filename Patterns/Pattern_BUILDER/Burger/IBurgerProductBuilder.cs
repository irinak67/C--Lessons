
namespace Pattern_BUILDER.Burger
{
    public interface IBurgerProductBuilder
    {
        IBurgerProductBuilder BuildTop();
        IBurgerProductBuilder BuildFilling();
        IBurgerProductBuilder BuildBase();

        BurgerProduct GetProduct();
    }
}
