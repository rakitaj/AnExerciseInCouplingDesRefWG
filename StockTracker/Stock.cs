using System.Runtime.InteropServices;

namespace StockTracker
{
    // Stores stocks
    public class Stock
    {
        public Stock(string ticker, double shares, double purchasePrice, string purchaseDate)
        {
            Ticker = ticker;
            Shares = shares;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
        }

        public string Ticker { get; }
        public double Shares { get; }
        public double PurchasePrice { get; }
        public string PurchaseDate { get; }

        public override string ToString()
        {
            return Ticker + ":" + Shares + ":" + PurchasePrice + ":" + PurchaseDate;
        }
    }
}