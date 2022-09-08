namespace Pattern_TEMPLATE_METHOD
{
    public class MeatPie : PieBase
    {
        public override void CreateDough()
        {
            Console.WriteLine("We use yeast dough"); 
        }

        public override void CreateFilling()
        {
            Console.WriteLine("Cooking meat stuffing");
        }

        public override void Fry()
        {
            Console.WriteLine("Bake in the oven at 210 degrees for 50 minutes."); ;
        }

        public override string ToString()
        {
            return "MeatPie";
        }
    }
}
