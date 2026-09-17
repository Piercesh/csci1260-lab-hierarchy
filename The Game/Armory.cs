using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public class Armory : IReportable
    {
        private string name;
        private List<Holding> items;

        public string Name { get { return name; } }
        public int Count { get { return items.Count; } }
        public Armory(string name)
        {
            this.name = name;
            this.items = new List<Holding>();
        }

        public bool Add(Holding item)
        {
            if (item == null)
                return false;

            items.Add(item);
            return true;
        }

        public Holding Find(string sku)
        {
            foreach (Holding item in items)
            {
                if (item.Sku == sku)
                    return item;
            }
            return null;
        }
        public decimal TotalValue()
        {
            decimal total = 0;
            foreach (Holding item in items)
            {
                total += item.ExtendedValue();
            }
            return total;
        }

        public decimal SaleValue()
        {
            decimal total = 0m;
            foreach (Holding item in items)
            {
                if (item is IDiscountable discountableItem && discountableItem.IsOnSale)
                {
                    total += discountableItem.SalePrice() * item.QuantityOnHand;
                }
                else
                {
                    total += item.ExtendedValue();
                }
            }
            return total;
        }

        public int SignedCount() 
        {
            int count = 0;
            foreach (Holding item in items)
            {
                if (item is IDiscountable discountableItem && discountableItem.IsOnSale)
                {
                    count ++;
                }
            }
            return count;

            
        }
        public int OnSaleCount()
        {
                       int count = 0;
            foreach (Holding item in items)
            {
                if (item is IDiscountable discountableItem && discountableItem.IsOnSale)
                {
                    count++;
                }
            }
            return count;
        }

        public void SortByValue()
        {
            items.Sort(Beats);
        }

        private static int Beats(Holding a, Holding b)
        {
            if (a.ExtendedValue() > b.ExtendedValue())
                return -1;
            if (a.ExtendedValue() < b.ExtendedValue())
                return 1;
            return 0;
        }

        public string ReportLine()
        {
            return $"{Name} | " + $"Items: {Count} | " + $"Total Value: {TotalValue():C}";
        }

        public void PrintReport()
        {
            Console.WriteLine($"=== {Name} ===");
            foreach (Holding item in items)
            {
                Console.WriteLine(item.ReportLine());
            }
            Console.WriteLine($"Total Items: {Count}");
            Console.WriteLine($"Total Value: {TotalValue():C}");
            Console.WriteLine($"Sale Value: {SaleValue():C}");
            Console.WriteLine($"On Sale: {OnSaleCount()}");
        }
    }
}
