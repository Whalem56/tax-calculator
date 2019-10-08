using System;
using System.Collections.Generic;
using System.Text;

namespace Tax_Calcuator
{
    class ShoppingBasket
    {
        private List<Item> Items { get; set; }
        public ShoppingBasket()
        {
            Items = new List<Item>();
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void PrintSales()
        {
            decimal salesTax = 0m;
            decimal total = 0m;
            foreach (Item item in Items)
            {
                Console.WriteLine($"\t1 {item.Name}: {item.Price}");
                salesTax += item.SalesTax;
                total += item.Price;
            }
            Console.WriteLine($"\tSales Taxes: {salesTax}");
            Console.WriteLine($"\tTotal: {total}");
        }
    }
}
