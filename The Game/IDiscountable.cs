using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    public interface IDiscountable
    {
        bool IsOnSale { get; }
        decimal SalePrice();
    }
}
