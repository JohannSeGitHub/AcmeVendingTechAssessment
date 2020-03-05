using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeMachine
{
    public class CoinContainer : List<Coins>
    {
        //Helper class for coins allowed and calculation
        public CoinContainer(decimal tender, List<Coin> coinsAllowed)
        {
            if (!coinsAllowed.SequenceEqual(coinsAllowed.OrderByDescending(c => c.Value)))
            {
                throw new ArgumentException(
                    "The coinsAllowed parameter must be ordered in descending face value");
            }

            foreach (var checkCoin in coinsAllowed)
            {
                var noOfCoins = GetNumberOfCoins(ref tender, checkCoin.Value);
                Add(new Coins
                {
                    CoinType = checkCoin,
                    CoinCount = noOfCoins
                });
            }
        }

        private int GetNumberOfCoins(ref decimal change, decimal minValue)
        {
            if (change < minValue)
            {
                return 0;
            }

            var coins = (int)Math.Floor(change / minValue);
            change = change % minValue;

            return coins;
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool includeZeroCountCoins)
        {
            var coins = includeZeroCountCoins ? this : this.Where(c => c.CoinCount != 0);

            return string.Join(", ", coins.Select(c =>
                string.Format(
                    "{0} {1}",
                    c.CoinCount,
                    c.CoinType.Denomination)));
        }
    }
}
