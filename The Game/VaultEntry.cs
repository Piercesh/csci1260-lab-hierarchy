using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// The VaultyEntry 
    /// </summary>
    public class VaultEntry
    {
        private int seq;
        private string kind;
        private int count;
        public int Seq { get; } = 0;

        public string Kind { get; }

        public int Count { get; } = 0;
        public VaultEntry(int seq, string kind, int count)
        {
            this.seq = seq;
            this.kind = kind;
            this.count = count;
        }
        public string Describe()
        {
          return $"{seq}: {kind} {count}";
        }
    }
}
