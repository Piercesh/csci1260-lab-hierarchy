using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// IDiscountable will get the price and sale price of an item if it is on sale.
    /// </summary>
    public interface IDiscountable
    {
        bool IsOnSale { get; }
        decimal SalePrice();
    }
}
