namespace Pattern_FACTORY_METHOD
{
    public class DollarCashMachine : CashMachine
    {
        private readonly int _countOnPage = 50;
        private int _denomination;
        private int[] _correntDenomination = { 1, 2, 5, 10, 20, 50, 100, 500, 1000, 5000, 1000 };

        public DollarCashMachine(int denomination = 100) : base("American dollar printer")
        {
            if(denomination <= 0)
            {
                throw new ArgumentOutOfRangeException("Denomination must be greater than zero.", nameof(denomination));
            }
            if(!_correntDenomination.Contains(denomination))
            {
                throw new ArgumentOutOfRangeException("Incorrect denomination", nameof(_correntDenomination));
            }
            _denomination = denomination;
        }
        public override MoneyBase[] Create(int pageCount)
        {
            var count = _countOnPage * pageCount;
            var money = new List<MoneyBase>();
            for (int i = 0; i < count; i++)
            {
                var dollar = new Dollar(_denomination);
                money.Add(dollar);
            }
            return money.ToArray();
        }
    }
}    
