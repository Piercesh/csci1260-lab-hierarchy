using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// In the enchantedgear, it is connected to the equipment and IDiscountable.
    /// in the class, shelflifedays is set to private and has SechargeFee set to 5.00m
    /// </summary>
    public class EnchantedGear : Equipment, IDiscountable
    {      
        private int shelfLifeDays;

        public const decimal SurchargeFee = 5.00m;
        /// <summary>
        /// This will return the ShelfLifeDays
        /// </summary>
        public int ShelfLifeDays
        {
            get { return shelfLifeDays; }
        }
        /// <summary>
        /// This will show when it is on Sale.
        /// </summary>
        public bool IsOnSale
        {
            get { return shelfLifeDays <= 30; }
        }
        /// <summary>
        /// This will add ShelfLifeDays to the code and show the days.
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="name"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="weightPounds"></param>
        /// <param name="shelfLifeDays"></param>
        public EnchantedGear(string sku, string name, decimal unitPrice, int quantityOnHand, double weightPounds, int shelfLifeDays) : base(sku, name, unitPrice, quantityOnHand, weightPounds)
        {
            this.shelfLifeDays = shelfLifeDays;
        }
        /// <summary>
        /// You need to override the Category for it to return the enchanted gear that will show.
        /// </summary>
        /// <returns></returns>
        public override string Category()
        {
            return "Enchanted Gear";
        }
        /// <summary>
        /// This class will be set to override and will return ShippingCost and add to SurchargeFee
        /// </summary>
        /// <returns></returns>
        public override decimal HandFee()
        {
            return ShippingCost() + SurchargeFee;
        }
        /// <summary>
        /// The Sale Price will get the untiprice and also has 0.90m set.
        /// </summary>
        /// <returns></returns>
        public decimal SalePrice()
        {
            if (! IsOnSale)
            {
                return UnitPrice;
            }
            return UnitPrice * 0.90m;
        }
        /// <summary>
        /// You need to Override the Describe for it to show up in the code.
        /// </summary>
        /// <returns></returns>
        public override string Describe()
        {
            return $"{Sku} - {Name}," + $"Enchanted Gear, " + $"Shelf Life: {ShelfLifeDays} days, " + $"Weight: {WeightPounds} lbs";
        }
    }
}
