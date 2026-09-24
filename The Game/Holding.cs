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
        /// <summary>
        /// Over here are the private code and the public code
        /// The public is to get and return the things that were needed for this code.
        /// </summary>
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
        /// <summary>
        /// In this part of the code it will recieve the items that have been put in the code.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This part will release the info that was put in the code
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Here is where the string will show the history of the items that will show when running the code.
        /// </summary>
        /// <returns></returns>
        public string MovementLines()
        {
            string result = "";
            foreach (VaultEntry entry in history)
            {
                result += entry.ToString() + Environment.NewLine;
            }
            return result;
        }
        /// <summary>
        /// This string will show and return the sku and the name.
        /// </summary>
        /// <returns></returns>
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
