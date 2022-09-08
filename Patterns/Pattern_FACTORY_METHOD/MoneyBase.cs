namespace Pattern_FACTORY_METHOD
{
    public abstract class MoneyBase
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public MoneyBase(string name, string symbol)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            if(string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentNullException("symbol");
            }
            Name = name;
            Symbol = symbol;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
