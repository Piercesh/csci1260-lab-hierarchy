using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// The consumable class will be connected to the Holding and IDiscountable.
    /// </summary>
    public class Consumable :Holding, IDiscountable
    {
        /// <summary>
        /// Here you have the private and public LaborsHours that are set to double.
        /// </summary>
        private double laborHours;
        public double LaborHours
        {
            get { return laborHours; }
        }
        /// <summary>
        /// The IsOnSale is going to need the QuantityOnHand
        /// </summary>
        public bool IsOnSale
        {
            get { return QuantityOnHand > 0; }
        }
        /// <summary>
        /// Over here the consumable will get the classes and have them for the LaborHours
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="name"></param>
        /// <param name="untiPrice"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="laborHours"></param>
        public Consumable(string sku, string name, decimal untiPrice, int quantityOnHand, double laborHours) : base(sku, name, untiPrice, quantityOnHand)
        {
            this.laborHours = laborHours;
        }
        /// <summary>
        /// This will have an override and here it will get the consumable.
        /// </summary>
        /// <returns></returns>
        public override string Category()
        {
             return "Consumable";
        }
        /// <summary>
        /// This will have an override and here is how it will get the handfee for the laborhours
        /// </summary>
        /// <returns></returns>
        public override decimal HandFee()
        {
            return (decimal)laborHours;
        }
        /// <summary>
        /// This will get the SalePrice
        /// </summary>
        /// <returns></returns>
        public decimal SalePrice()
        {
            return UnitPrice;
        }
        /// <summary>
        /// This describe will also have an override for it to work
        /// This will show the Labor Hours and the consumable
        /// </summary>
        /// <returns></returns>
        public override string Describe()
        {
            return $"{Sku} - {Name}, " + $"Consumable, " + $"Labor Hours: {LaborHours} hours";
        }
    }
}
