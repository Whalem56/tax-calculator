using System;
using System.Collections.Generic;
using System.Text;

namespace Tax_Calcuator
{
    class Item
    {
        public string Name { get; set; }

        private decimal ShelfPrice { get; set; }

        private bool HasSalesTax { get; set; }

        private bool HasImportTax { get; set; }

        private decimal TaxMultiplier { get; set; }

        public decimal SalesTax { get; set; }

        public decimal Price { get; set; }

        public Item(string name, decimal shelfPrice, bool hasSalesTax, bool hasImportTax)
        {
            Name = name;
            ShelfPrice = shelfPrice;
            HasSalesTax = hasSalesTax;
            HasImportTax = hasImportTax;
            TaxMultiplier = CalculateTaxMultiplier();
            SalesTax = CalculateSalesTax();
            Price = ShelfPrice + SalesTax;
        }

        private decimal CalculateTaxMultiplier()
        {
            decimal taxMultiplier = 0m;

            if (HasSalesTax)
                taxMultiplier += .1m;
            if (HasImportTax)
                taxMultiplier += .05m;

            return taxMultiplier;
        }

        private decimal CalculateSalesTax()
        {
            decimal salesTax = ShelfPrice * TaxMultiplier;

            // Round up to nearest 0.05 value
            salesTax = Math.Ceiling(salesTax / .05m) * .05m;

            return salesTax;
        }
    }
}
