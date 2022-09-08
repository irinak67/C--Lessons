namespace Pattern_TEMPLATE_METHOD
{
    public class ApplePie : PieBase
    {
        public override void CreateDough()
        {
            Console.WriteLine("We use puff pastry"); 
        }

        public override void CreateFilling()
        {
            Console.WriteLine("Making apple filling");
        }

        public override void Fry()
        {
            Console.WriteLine("Bake in the oven at 180 degrees for 30 minutes.");
        }

        public override string ToString()
        {
            return "ApplePie";
        }
    }
}
