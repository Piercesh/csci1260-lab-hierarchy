using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// The Holding class needs to be abstract and also has to have IReportable Interface for it 
    /// to have access to name and sku and other data in the code.
    /// </summary>
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
        /// <summary>
        /// Here the two classes Category and HandFee will need to be abstract classes
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Here is where the Reportline will be, it will return the name, sku, Category, QTY, UnitPrice, ExtendedValue and HandlingFee.
        /// </summary>
        /// <returns></returns>
        public string ReportLine()
        {
            return $"{sku} | {name} | {Category()} | " + $"Qty: {quantityOnHand} | " + $"Unit Price: {unitPrice:C} | " + $"Extended Value: {ExtendedValue():C} | " + $"Handling Fee: {HandFee():C}";
        }
        /// <summary>
        /// For here you will need to have the override for the ToString class to make it work.
        /// in the class you will need to return the Describe()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Describe();
        }
    }
}
