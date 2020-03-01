using System;

namespace ChangeMachine
{
    public class Coin
    {
        public string Currency { get; set; }
        public string Denomination { get; set; }
        public decimal Value { get; set; }

        public Coin(string currency, string denomination, decimal coinValue)
        {
            Currency = currency;
            Denomination = denomination;
            Value = coinValue;
        }
    }
}
