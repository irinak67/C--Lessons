namespace Pattern_TEMPLATE_METHOD
{
    public abstract class PieBase
    {
        public void Cook()
        {
            CreateDough();
            CreateFilling();
            Fry();
        }
        public abstract void CreateDough();
        public abstract void CreateFilling();
        public abstract void Fry();
    }
}
