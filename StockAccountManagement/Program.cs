namespace StockAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockOperations stockOperations = new StockOperations();

            Console.WriteLine("************STOCK ACCOUNT MANAGEMENT************");
            Console.WriteLine("----------------------------------------------------");

            int choice = 0;
            while(choice != 4)
            {
                Console.WriteLine("1.Buy a Share \n2.Sell a share \n3.View Transaction History \n4.Exit");
                Console.WriteLine("Enter choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Stock Name: ");
                        string stockName = Console.ReadLine();

                        Console.Write("Quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.Write("Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        
                        stockOperations.BuyStock(stockName, quantity, price);
                        Console.WriteLine("Stock bought successfully.");
                        Console.WriteLine("----------------------------------------------------");
                        break;


                   case 2:
                        Console.Write("Stock Name: ");
                        stockName = Console.ReadLine();

                        Console.Write("Quantity: ");
                        quantity = int.Parse(Console.ReadLine());

                        Console.Write("Price: ");
                        price = decimal.Parse(Console.ReadLine());

                        int availableQuantity = stockOperations.GetAvailableQuantity(stockName);

                        if (quantity <= availableQuantity)
                        {
                            stockOperations.SellStock(stockName, quantity, price);
                            Console.WriteLine("Stock sold successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Can't sell stock more than " + availableQuantity);
                        }

                       
                        Console.WriteLine("----------------------------------------------------");
                        break;

                    case 3:
                        stockOperations.DisplayStockReport();
                        Console.WriteLine("----------------------------------------------------");
                        break;

                }

            }
            


        }
    }
}