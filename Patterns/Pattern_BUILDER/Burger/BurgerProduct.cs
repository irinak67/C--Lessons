using System.Text;

namespace Pattern_BUILDER.Burger;
public class BurgerProduct
{
    public string BurgerTop { get; set; }
    public string BurgerFilling { get; set; }
    public string BurgerBase { get; set; }
    public override string ToString() =>
        new StringBuilder()
            .Append(BurgerTop)
            .Append(BurgerFilling)
            .Append(BurgerBase)
            .ToString();
}
