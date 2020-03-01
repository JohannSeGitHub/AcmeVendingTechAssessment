using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChangeMachine
{
    //Playing between 2 coin batches. This struct verion and then a the class list verion in MachineCurrency class   

    public struct USD
    {
        [Description("United States Dollar : 25 cents")]
        public const Decimal Quarter = 0.25M;
        [Description("United States Dollar : 10 cents")]
        public const Decimal Dime = 0.10M;
        [Description("United States Dollar : 5 cents")]
        public const Decimal Nickel = 0.05M;
        [Description("United States Dollar : 1 cents")]
        public const Decimal Penny = 0.01M;
        [Description("United States Dollar Symbol")]
        public const string CurrencySymbol = "$";
        [Description("Return list of struct detail")]
        public static void ConsoleWrite()
        {
            Console.WriteLine("");
            Console.WriteLine("United States Dollar : USD -> " + CurrencySymbol);
            Console.WriteLine("- Quarter : 25 cents");
            Console.WriteLine("- Dime : 10 cents");
            Console.WriteLine("- Nickel : 5 cents");
            Console.WriteLine("- Penny : 1 cents");
        }

    }

    public struct GBR
    {
        [Description("British Pound : 50 pence")]
        public const Decimal FiftyPence = 0.50M;
        [Description("British Pound : 20 pence")]
        public const Decimal TwentyPence = 0.20M;
        [Description("British Pound : 10 pence")]
        public const Decimal TenPence = 0.10M;
        [Description("British Pound : 5 pence")]
        public const Decimal FivePence = 0.05M;
        [Description("British Pound : 2 pence")]
        public const Decimal TwoPence = 0.02M;
        [Description("British Pound : 1 pence")]
        public const Decimal OnePence = 0.01M;
        [Description("British Pound Symbol")]
        public const string CurrencySymbol = "£";
        public static void ConsoleWrite()
        {
            Console.WriteLine("");
            Console.WriteLine("British Pound : GBR -> " + CurrencySymbol);
            Console.WriteLine("- 50p : 50 pence");
            Console.WriteLine("- 20p : 20 pence");
            Console.WriteLine("- 10p : 10 pence");
            Console.WriteLine("- 5p : 5 pence");
            Console.WriteLine("- 2p : 2 pence");
            Console.WriteLine("- 1p : 1 pence");
        }
    }
    //mmmmm
    public enum AllowedCurrency
    {
        [Description("United States Dollar : $")]
        USD = 1,
        [Description("British Pound : £")]
        GBP = 2
    }

}
