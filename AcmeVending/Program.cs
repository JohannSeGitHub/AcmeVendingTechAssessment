using ChangeMachine;
using System;
using System.ComponentModel;
using System.Reflection;

namespace AcmeVending
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize Welcome screen 
            Console.WriteLine("Welcome to Acme Vending company!");
            Console.WriteLine("Remember to press the Enter button after making a selection.");
            Console.WriteLine("You can cancel this transaction at any time by pressing ctrl + c.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("To view supported currency press V, press C to continue with transaction or press Q to quit. ");

            StartTransactionOrViewCurrency(Console.ReadLine().ToUpper());
            SelectCurrencyOrQuit();
            
            // Get tendered amount  
            Console.Write("Tendered Amount: ");
            var tender = Console.ReadLine();

            //Utilize ChangeMachine library to calculate change requirements


            Console.WriteLine("Calculaing......Calculating......");
            Console.WriteLine("Thank you and enjoy your day. :-)");
            Console.Write("Press any key to complete this transaction.");
            Console.ReadKey(true);
        }

        private static void StartTransactionOrViewCurrency(string whatNext)
        {
            bool transactionNotStarted = true;

            while (transactionNotStarted)
            {
                
                char option = char.Parse(string.IsNullOrEmpty(whatNext) ? "z" : whatNext);

                switch (option)
                {
                    case 'C':
                        Console.WriteLine("Continue to transaction...");
                        Console.WriteLine("......");
                        transactionNotStarted = false;
                        break;
                    case 'V':
                        Console.WriteLine("Please see below currency and denomination supported by this machine.");
                        transactionNotStarted = false;
                        USD.ConsoleWrite();
                        GBR.ConsoleWrite();
                        break;
                    case 'Q':
                        Console.WriteLine("Exiting Application...");
                        System.Environment.Exit(1);
                        break;
                    default:                        
                        Console.WriteLine("Invalid input. Please try again.");
                        transactionNotStarted = true;
                        Console.WriteLine("To view supported currency press V, press C to continue with transaction or press Q to quit. ");
                        whatNext = Console.ReadLine().ToUpper();
                        break;
                }
            }
        }

        private static void SelectCurrencyOrQuit()
        {
            bool invalidInput = true;
            Console.Write("Please select currency. Press U for USD or G for GBR. Press Q to quit.");

            while (invalidInput)
            {
                string currencySelected = Console.ReadLine().ToUpper();
                char option = char.Parse(currencySelected);

                switch (option)
                {
                    case 'U':
                        Console.WriteLine("You selected US Dollar!");
                        invalidInput = false;
                        break;
                    case 'G':
                        Console.WriteLine("You selected British pound!");
                        invalidInput = false;
                        break;
                    case 'Q':
                        Console.WriteLine("Exiting Application...");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        Console.Write("Please select currency. Press U for USD or G for GBR. Press Q to quit.");
                        break;
                }
            }
        }

    }
}
