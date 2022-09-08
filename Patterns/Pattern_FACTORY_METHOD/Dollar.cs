namespace Pattern_FACTORY_METHOD
{
    public class Dollar: MoneyBase
    {
        public Guid Number { get; protected set; }
        public int Volume { get; protected set; }
        public Dollar(int volume): base("American dollar", "$")
        {
            if(volume <= 0)
            {
                throw new ArgumentOutOfRangeException("Denomination must be greater than zero.", nameof(volume));
            }
            Number = Guid.NewGuid();
            Volume = volume;
        }
        public override string ToString()
        {
            return $"{Name} {Number} by denomination {Volume} {Symbol}";
        }
    }
}
