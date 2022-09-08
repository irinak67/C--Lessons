namespace Pattern_FACTORY_METHOD
{
    public abstract class CashMachine
    {
        public string Name { get; protected set; }
        public CashMachine(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
        }
        public abstract MoneyBase[] Create(int pageCount);
        public override string ToString()
        {
            return Name;
        }
    }
}
