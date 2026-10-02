using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// GroupedByKey will also implement IComparer<LootDrop></LootDrop>
    /// </summary>
    public class GroupedByKey : IComparer<LootDrop>
    {
        /// <summary>
        /// In this code, it will almost be the same as HighestValeFirst.
        /// This time instead of gold, it will be monster.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(LootDrop a, LootDrop b)
        {
            if (ReferenceEquals(a, b)) 
                return 0;
            if (a == null) 
                return 1;
            if (b == null) 
                return -1;
            int result = string.Compare(a.Monster, b.Monster, StringComparison.Ordinal);
            if (result != 0) 
                return result;
            return a.CompareTo(b);
        }
    }
}
