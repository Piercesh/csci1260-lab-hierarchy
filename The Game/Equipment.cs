using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public abstract class Equipment : Holding
    {
        
        private double weightPounds;

        public const decimal HandlingRate = 0.60m;


        
        public double WeightPounds
        {
            get { return weightPounds; }
        }

        protected Equipment(string sku, string name, decimal unitPrice, int quantityOnHand, double weightPounds) : base(sku, name, unitPrice, quantityOnHand)
        {
            this.weightPounds = weightPounds;
        }
        public decimal ShippingCost()
        {
            return (decimal)weightPounds * HandlingRate;
        }

        public override string Describe()
        {
            return $"{Sku} - {Name}," +
                $"Weight: {WeightPounds} lbs, " +
                $"Shipping: {ShippingCost():C}";
        }

    }
}
