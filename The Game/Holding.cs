using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public abstract class Holding
    {
        private string sku;
        private string name;
        private decimal unitPrice;
        private int quantityOnHand;
        private List<VaultEntry> history;
        private int nextSeq;

        public string Sku { get { return sku; } }
        public string Name { get { return name; } }
        public decimal UnitPrice { get { return unitPrice; } }
        public int QuantityOnHand { get { return quantityOnHand; } }
        public int MoveCount { get { return history.Count; } }
        protected Holding(string sku, string name, decimal unitPrice, int quantityOnHand)
        {
            this.sku = sku;
            this.name = name;
            this.unitPrice = unitPrice;
            this.quantityOnHand = quantityOnHand;
            this.history = new List<VaultEntry>();
            this.nextSeq = 1;
        }

        public abstract string Category();

    }
}
