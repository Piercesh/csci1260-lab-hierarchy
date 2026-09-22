using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// Here is IReportable will be connected to the Armory.
    /// </summary>
    public class Armory : IReportable
    {
        private string name;
        private List<Holding> items;
        /// <summary>
        /// Here you have the name for the items & should keep the count of the items.
        /// </summary>
        public string Name { get { return name; } }
        public int Count { get { return items.Count; } }
        public Armory(string name)
        {
            this.name = name;
            this.items = new List<Holding>();
        }
        /// <summary>
        /// This will add new items if it is true,
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This will get the total value of the items that have been put in.
        /// </summary>
        /// <returns></returns>
        public decimal TotalValue()
        {
            decimal total = 0;
            foreach (Holding item in items)
            {
                total += item.ExtendedValue();
            }
            return total;
        }
        /// <summary>
        /// This will get the sale value and the quantity of the item.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// This will sort the items by its value
        /// </summary>
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
        /// <summary>
        /// In this string, when you run the code this should show the name, count and total value of the item.
        /// </summary>
        /// <returns></returns>
        public string ReportLine()
        {
            return $"{Name} | " + $"Items: {Count} | " + $"Total Value: {TotalValue():C}";
        }
        /// <summary>
        /// Here is where it will show the name, the total items, the total value, sale value, and the on sale.
        /// </summary>
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
