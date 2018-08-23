using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            // Add a few more of your favorite stocks
            stocks.Add("AAPL", "Apple");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("NVDA", "Nvidia");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            // Add more for each stock you added to the stocks dictionary
            purchases.Add((ticker: "APPL", shares: 100, price: 215.05));
            purchases.Add((ticker: "MSFT", shares: 200, price: 107.06));
            purchases.Add((ticker: "NVDA", shares: 300, price: 262.82));

            /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the valuation of each stock (price*amount)

    {
        "General Electric": 35900,
        "AAPL": 8445,
        ...
    }
*/
            Dictionary<string, double> valuation = new Dictionary<string, double>(){
        {"General Electric", 35900},
        {"Apple", 8445},
        {"Caterpillar", 100},
        {"Microsoft",300},
        {"Nvidia",200}
    };


            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                if(purchase.ContainsKey(ticker)){
                // If it does, update the total valuation

                }
                // If not, add the new key and set its value
            }
        }
    }
}
