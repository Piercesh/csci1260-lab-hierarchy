using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// The VaultyEntry will be the important classes as this will get the seq kind and count.
    /// </summary>
    public class VaultEntry
    {
        /// <summary>
        /// Here are the private and public seq, kind, and count.
        /// </summary>
        private int seq;
        private string kind;
        private int count;
        public int Seq { get; } = 0;

        public string Kind { get; }

        public int Count { get; } = 0;
        /// <summary>
        /// Here is the public vault entry where it will get the seq, kind and count
        /// </summary>
        /// <param name="seq"></param>
        /// <param name="kind"></param>
        /// <param name="count"></param>
        public VaultEntry(int seq, string kind, int count)
        {
            this.seq = seq;
            this.kind = kind;
            this.count = count;
        }
        /// <summary>
        /// This is where it will describe and return the seq, kind and count.
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
          return $"{seq}: {kind} {count}";
        }
    }
}
