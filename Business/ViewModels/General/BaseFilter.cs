using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.General
{
    public class BaseFilter
    {
        public int Lang { get; set; } = 1;
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}
