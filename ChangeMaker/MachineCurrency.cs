using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMachine
{
    public class MachineCurrency
    {
        //Playing between 2 coin batches. This class list verion and then a the struct version in MachineCurrencyStructures
        public List<Coin> usaCoins = new List<Coin>
        {
            new Coin("USD","quarter",0.25m),
            new Coin("USD","dime",0.10m),
            new Coin("USD","nickel",0.05m),
            new Coin("USD","penny",0.01m )
        };

        public List<Coin> britishCoins = new List<Coin>
        {
            new Coin("GBR","two pound",2.00m),
            new Coin("GBR","pound",1.00m),
            new Coin("GBR","fifty pence",0.50m),
            new Coin("GBR","twenty pence",0.20m),
            new Coin("GBR","ten pence",0.10m),
            new Coin("GBR","five pence",0.05m),
            new Coin("GBR","two pence",0.02m),
            new Coin("GBR","one pence",0.01m)
        };
    }
}
