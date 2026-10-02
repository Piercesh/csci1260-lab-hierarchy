using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// You will need three interfaces that must be added for LootDrop.
    /// You will need IEquatable<T>, IComparable<T>, and IComparer<T> as they are important for not just this code.
    /// But it will also be needed for HighestValueFirst and GroupedByKey.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEquatable<T>
    {
        bool Equals(T other);
    } 
    
    public interface IComparable<T>
    {
        int CompareTo(T other);
    }

    public interface IComparer<T>
    {
           int Compare(T a, T b);
    }
    /// <summary>
    /// LootDrop will implement IEquatable<LootDrop> and IComparable<LootDrop> as it is important for the code to work.
    /// </summary>
    public class LootDrop : IEquatable<LootDrop>, IComparable<LootDrop>
    {
        /// <summary>
        /// Here is the code for LootDrop that will have the monster, dropNo, and gold.
        /// and there is the public get that will get the monster, dropNo, and gold.
        /// </summary>
        private string monster;
        private int dropNo;
        private double gold; 

        public string Monster 
        {
            get { return monster; }
        }

        public int DropNo
        {
            get { return dropNo; }
        }

        public double Gold 
        { 
            get { return gold; }
        }
        // This is where the public LootDrop will get the monster, dropNo, and gold.
        public LootDrop (string monster, int dropNo, double gold)
        {
            this.monster = monster;
            this.dropNo = dropNo;
            this.gold = gold;
        }
        // Here is one of the equals methods that will check if the monster, dropNo, and gold are equal to each other.
        public bool Equals(LootDrop other)
        {
            if (other == null) return false;
            return monster == other.monster && dropNo == other.dropNo && gold == other.gold;
        }
        // This other equals will need an override and will have object for LootDrop.
        public override bool Equals(object obj)
        {
            return Equals(obj as LootDrop);
        }
        /// <summary>
        /// You need to override the GetHashCode()
        /// For this one you need to do HashCode.Combine to get monster, dropNo, and gold.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(monster, dropNo, gold);
        }
        /// <summary>
        ///  In this one you have the if statements if the results are not equal to 0
        ///  then it will return the results for monster, dropNo, and gold.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(LootDrop other)
        {
            if (other == null) return 1;
            int result = string.Compare(monster, other.monster, StringComparison.Ordinal);
            if (result != 0) return result;
            result = dropNo.CompareTo(other.dropNo);
            if (result != 0) return result;
            return gold.CompareTo(other.gold);
        }
        /// <summary>
        /// You need the override ToString() to show the monster, dropNo, and gold.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Monster: {monster}, {dropNo}, Gold: {gold}";
        }   
    }
}
