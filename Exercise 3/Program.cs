namespace Exercise_3
{
    internal class Program
    {
        struct Price
        {
            public string NameItem { get; set; }
            public string NameStore { get; set; }
            public decimal PriceItem { get; set; }
        }
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Input  {i + 1}  item:");
                string nameItem = Console.ReadLine();
                Console.Write("  Input Name Store: ");
                string nameStore = Console.ReadLine();


                decimal priceItem;
                while (true)
                {
                    Console.Write("  Input Price: ");
                    try
                    {
                        priceItem = decimal.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not decimal");
                    }
                }
                prices[i] = new Price
                {
                    NameItem = nameItem,
                    NameStore = nameStore,
                    PriceItem = priceItem
                };
            }
            prices = prices.OrderBy(x =>x.NameStore).ToArray();
            Console.Write("Enter store name to display products: ");
            string storeToDisplay = Console.ReadLine();

            bool storeFound = false;

            foreach (Price price in prices)
            {
                if (price.NameStore == storeToDisplay)
                {
                    storeFound = true;
                    Console.WriteLine($"Product: {price.NameItem}, Price: {price.PriceItem}");
                }
            }

            if (!storeFound)
            {
                throw new Exception("Store not found.");
            }

            Console.ReadKey();

        }
    }
}