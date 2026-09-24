using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// Here is the abstract class and is also connected to holding.
    /// In the class there is the const decimal for handlingrate and has been set to 0.60;
    /// </summary>
    public abstract class Equipment : Holding
    {
        
        private double weightPounds;

        public const decimal HandlingRate = 0.60m;


        /// <summary>
        /// This class is set to double and it will get and return the weightpounds.
        /// </summary>
        public double WeightPounds
        {
            get { return weightPounds; }
        }
        /// <summary>
        /// In this code it will get the weightpounds for the sku, name, unitprice, quantityonhand, and weightpounds 
        /// and it will also come with a base as well.
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="name"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="weightPounds"></param>
        protected Equipment(string sku, string name, decimal unitPrice, int quantityOnHand, double weightPounds) : base(sku, name, unitPrice, quantityOnHand)
        {
            this.weightPounds = weightPounds;
        }
        /// <summary>
        /// Here the shoppingcost will return the decimal of the weightpounds and handlingrate.
        /// </summary>
        /// <returns></returns>
        public decimal ShippingCost()
        {
            return (decimal)weightPounds * HandlingRate;
        }
        /// <summary>
        /// this here will override the string and will allow you to use Describe in this class
        /// This class will not only get the sku and name, but will also get the weight and the shopping cost.
        /// </summary>
        /// <returns></returns>
        public override string Describe()
        {
            return $"{Sku} - {Name}," +
                $"Weight: {WeightPounds} lbs, " +
                $"Shipping: {ShippingCost():C}";
        }

    }
}
