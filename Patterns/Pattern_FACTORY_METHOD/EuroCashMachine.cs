namespace Pattern_FACTORY_METHOD
{
    public class EuroCashMachine : CashMachine
    {
        private int _denomination;
        public EuroCashMachine(int denomination = 100): base("Euro printer")
        {
            if(denomination <= 0)
            {
                throw new ArgumentOutOfRangeException("Denomination must be greater than zero.", nameof(denomination));
            }
            var correntDenomination = new int[] { 5, 10, 20, 50, 100, 200, 500 };
            if(!correntDenomination.Contains(denomination))
            {
                throw new ArgumentOutOfRangeException("Incorrect denomination", nameof(correntDenomination));
            }
        
            _denomination = denomination;
        }

        public override MoneyBase[] Create(int pageCount)
        {
            var countOnPage = 50;
            var count = countOnPage * pageCount;
            var money = new List<MoneyBase>();

            for (int i = 0; i < count; i++)
            {
                var euro = new Euro(_denomination);
                money.Add(euro);
            }
            return money.ToArray();
        }
    }
}
