using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StockAccountManagement
{
    class StockOperations
    {
        private List<StockTransaction> transactionlist;

        public StockOperations()
        {
            transactionlist= new List<StockTransaction>();
        }


        public void BuyStock(string stockName, int quantity, decimal price)
        { 
            
        StockTransaction transaction = new StockTransaction
            {
                stockName = stockName,
                stockQuantity = quantity,
                stockPrice = price,
                dateTime = DateTime.Now,
                isBuy = true
            };

            transactionlist.Add(transaction);
        }

        public void SellStock(string stockName, int quantity, decimal price)
        {
        StockTransaction transaction = new StockTransaction
        {
            stockName = stockName,
            stockQuantity = quantity,
            stockPrice = price,
            dateTime = DateTime.Now,
            isBuy = false
            };

           
            transactionlist.Add(transaction);
          
            
        }

        public int GetAvailableQuantity(string stockName)
        {
            int quantity = 0;

            foreach (StockTransaction transaction in transactionlist)
            {
                if (transaction.stockName == stockName)
                {
                    quantity += transaction.stockQuantity;
                }
                else
                {
                   quantity -= transaction.stockQuantity;
                }
            }

            return quantity;
        }


        public void DisplayStockReport()
        {
            Console.WriteLine("Stock Report:");

            foreach (StockTransaction transaction in transactionlist)
            {

                Console.WriteLine("Date and Time: " + transaction.dateTime);
                if(transaction.isBuy == true)
                {
                    Console.WriteLine(" Transaction Type : BUY");
                }
                else
                {
                    Console.WriteLine(" Transaction Type : SELL");
                }
                
                Console.WriteLine(" Stock Name: " + transaction.stockName);
                Console.WriteLine(" Quantity: " + transaction.stockQuantity);
                Console.WriteLine(" Price: " + transaction.stockPrice);
 
                Console.WriteLine("");
            }

            
        }
    }

   
}
