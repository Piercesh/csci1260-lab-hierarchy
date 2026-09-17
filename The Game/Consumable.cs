using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public class Consumable :Holding, IDiscountable
    {
        private double laborHours;
        public double LaborHours
        {
            get { return laborHours; }
        }

        public bool IsOnSale
        {
            get { return QuantityOnHand > 0; }
        }
        public Consumable(string sku, string name, decimal untiPrice, int quantityOnHand, double laborHours) : base(sku, name, untiPrice, quantityOnHand)
        {
            this.laborHours = laborHours;
        }

        public override string Category()
        {
             return "Consumable";
        }

        public override decimal HandFee()
        {
            return (decimal)laborHours;
        }

        public decimal SalePrice()
        {
            return UnitPrice;
        }

        public override string Describe()
        {
            return $"{Sku} - {Name}, " + $"Consumable, " + $"Labor Hours: {LaborHours} hours";
        }
    }
}
