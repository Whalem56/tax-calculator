using System;

namespace Tax_Calcuator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 1
            ShoppingBasket basket1 = new ShoppingBasket(); 
            basket1.Add(new Item("book", 12.49m, false, false));
            basket1.Add(new Item("music CD", 14.99m, true, false));
            basket1.Add(new Item("chocolate bar", 0.85m, false, false));
            Console.WriteLine("Output 1:");
            basket1.PrintSales();

            // Input 2
            ShoppingBasket basket2 = new ShoppingBasket();
            basket2.Add(new Item("imported box of chocolates", 10.00m, false, true));
            basket2.Add(new Item("imported bottle of perfume", 47.50m, true, true));
            Console.WriteLine("Output 2:");
            basket2.PrintSales();

            // Input 3
            ShoppingBasket basket3 = new ShoppingBasket();
            basket3.Add(new Item("imported bottle of perfume", 27.99m, true, true));
            basket3.Add(new Item("bottle of perfume", 18.99m, true, false));
            basket3.Add(new Item("packet of headache pills", 9.75m, false, false));
            basket3.Add(new Item("imported box of chocolates", 11.25m, false, true));
            Console.WriteLine("Output 3:");
            basket3.PrintSales();
        }
    }
}
