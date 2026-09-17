using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public abstract class Holding : IReportable
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
        public abstract decimal HandFee();
        public decimal ExtendedValue()
        {
            return unitPrice * quantityOnHand;
        }

        public bool Receive(int count)
        {
            if (count <= 0)
            {
                return false;
            }
            quantityOnHand += count;
            history.Add(new VaultEntry(nextSeq++, "Receive", count));

            nextSeq++;
            return true;
        }

        public bool Release(int count)
        {
            if (count <= 0 || count > quantityOnHand)
            {
                return false;
            }
            quantityOnHand -= count;
            history.Add(new VaultEntry(nextSeq++, "Release", count));
            nextSeq++;
            return true;
        }

        public string MovementLines()
        {
            string result = "";
            foreach (VaultEntry entry in history)
            {
                result += entry.ToString() + Environment.NewLine;
            }
            return result;
        }

        public virtual string Describe()
        {
            return $"{sku} - {name}";
        }

        public string ReportLine()
        {
            return $"{sku} | {name} | {Category()} | " + $"Qty: {quantityOnHand} | " + $"Unit Price: {unitPrice:C} | " + $"Extended Value: {ExtendedValue():C} | " + $"Handling Fee: {HandFee():C}";
        }

        public override string ToString()
        {
            return Describe();
        }
    }
}
