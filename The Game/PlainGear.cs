using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public class PlainGear : Equipment
    {
        private int warrantyMonths;
        public int WarrantyMonths
        {
            get { return warrantyMonths; }
        }

        public PlainGear(string sku, string name, decimal unitPrice, int quantiyOnHand, double weightPounds, int warrantyMonths) : base(sku, name, unitPrice, quantiyOnHand, weightPounds)
        {
            this.warrantyMonths = warrantyMonths;
        }

        public override string Category()
        {
            return "Plain Gear";
        }

        public override decimal HandFee()
        {
            return ShippingCost();
        }

        public override string Describe()
        {
            return $"{Sku} - {Name}, " +
                $"Plain Gear, " +
                $"Warranty: {WarrantyMonths} months, " +
                $"Weight: {WeightPounds} lbs";
        }
    }


}
