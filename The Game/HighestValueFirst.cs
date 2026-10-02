using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// HighestValueFirst will implement IComparer<LootDrop>
    /// </summary>
    public class HighestValueFirst : IComparer<LootDrop>
    {
        /// <summary>
        /// In this one, you will need to compare loot a  and loot b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(LootDrop a, LootDrop b)
        {
           // in this code, it will compare the gold that will show.
           if (ReferenceEquals(a, b)) 
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int result = b.Gold.CompareTo(a.Gold);
            if (result != 0) return result;
            return a.CompareTo(b);

        }
    }
}
