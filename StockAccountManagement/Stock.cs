using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Stock
    {
        public string name { get; set; }
        public int numberOfShares { get; set; }
        public decimal sharePrice { get; set; }

    }

    class StockTransaction
    {
        public string stockName { get; set; }
        public int stockQuantity { get; set; }
        public decimal stockPrice { get; set; }
        public DateTime dateTime { get; set; }
        public bool isBuy { get; set; }


    }
}
