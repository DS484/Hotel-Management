using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.HandleData
{
    public class FormatData
    {
        public string ConvertDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }
    }
}
