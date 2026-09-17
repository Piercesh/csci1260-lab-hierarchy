using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public abstract class Equipment
    {
        
        private double weightPounds;

        public decimal HandlingRate { 
            get { return 0.60m; }
        }
        
        public double WeightPounds
        {
            get { return weightPounds; }
            set { weightPounds = value; }
        }

        

    }
}
