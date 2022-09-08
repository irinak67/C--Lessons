namespace Pattern_FACTORY_METHOD
{
    public class Euro: MoneyBase
    {
        public int Number { get; protected set; }
        public int Denomination { get; protected set; }
        public Euro(int denomination): base("Euro", "€")
        {
            if(denomination <= 0)
            {
                throw new ArgumentOutOfRangeException("Denomination must be greater than zero.", nameof(denomination));
            }
            var rnd = new Random();
            Number = rnd.Next(100000000,999999999);
            Denomination = denomination;
        }
        public override string ToString()
        {
            return $"{Name} {Number} by denomination {Denomination} {Symbol}";
        }
    }
}
