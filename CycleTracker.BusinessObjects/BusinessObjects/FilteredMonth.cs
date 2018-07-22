using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{

    public class FilteredMonth
    {

        public FilteredMonth() { }

        public FilteredMonth(DateTime currentDate)
        {
            MonthId = currentDate.Month;
            MonthName = currentDate.ToString("MMMM");
        }

        public FilteredMonth (int monthId, string monthName)
        {
            MonthId = monthId;
            MonthName = monthName;
        }

        public int MonthId { get; set; }

        public string MonthName { get; set; }
    }
}
