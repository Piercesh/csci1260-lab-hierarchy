using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// In the enchantedgear, it is connected to the equipment and IDiscountable.
    /// in the class, shelflifedays is set to private and 
    /// </summary>
    public class EnchantedGear : Equipment, IDiscountable
    {      
        private int shelfLifeDays;

        public const decimal SurchargeFee = 5.00m;

        public int ShelfLifeDays
        {
            get { return shelfLifeDays; }
        }

        public bool IsOnSale
        {
            get { return shelfLifeDays <= 30; }
        }

        public EnchantedGear(string sku, string name, decimal unitPrice, int quantityOnHand, double weightPounds, int shelfLifeDays) : base(sku, name, unitPrice, quantityOnHand, weightPounds)
        {
            this.shelfLifeDays = shelfLifeDays;
        }
        public override string Category()
        {
            return "Enchanted Gear";
        }

        public override decimal HandFee()
        {
            return ShippingCost() + SurchargeFee;
        }

        public decimal SalePrice()
        {
            if (! IsOnSale)
            {
                return UnitPrice;
            }
            return UnitPrice * 0.90m;
        }

        public override string Describe()
        {
            return $"{Sku} - {Name}," + $"Enchanted Gear, " + $"Shelf Life: {ShelfLifeDays} days, " + $"Weight: {WeightPounds} lbs";
        }
    }
}
