using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// PlainGear will be connected to Equipment so it can be capable of using the classes in the equipment class
    /// WarrantyMonths has a public and private int.
    /// </summary>
    public class PlainGear : Equipment
    {
        private int warrantyMonths;
        public int WarrantyMonths
        {
            get { return warrantyMonths; }
        }
        /// <summary>
        /// This should allow it to show the warranymonths in PlainGear.
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="name"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantiyOnHand"></param>
        /// <param name="weightPounds"></param>
        /// <param name="warrantyMonths"></param>
        public PlainGear(string sku, string name, decimal unitPrice, int quantiyOnHand, double weightPounds, int warrantyMonths) : base(sku, name, unitPrice, quantiyOnHand, weightPounds)
        {
            this.warrantyMonths = warrantyMonths;
        }
        /// <summary>
        /// You need to override the Category to return Plain Gear.
        /// </summary>
        /// <returns></returns>
        public override string Category()
        {
            return "Plain Gear";
        }
        /// <summary>
        /// You will need to override the HandFee to use the ShippingCost
        /// </summary>
        /// <returns></returns>
        public override decimal HandFee()
        {
            return ShippingCost();
        }
        /// <summary>
        /// You will need to override the Describe one again so you can use it and so the code will
        /// be capable of using what has been put in.
        /// </summary>
        /// <returns></returns>
        public override string Describe()
        {
            return $"{Sku} - {Name}, " +
                $"Plain Gear, " +
                $"Warranty: {WarrantyMonths} months, " +
                $"Weight: {WeightPounds} lbs";
        }
    }


}
