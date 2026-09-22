using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// The IReportable will have the ReportLine that will show the info for the item or the armory.
    /// </summary>
    public interface IReportable
    {
        string ReportLine();
    }
}
