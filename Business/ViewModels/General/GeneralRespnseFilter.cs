using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.General
{
    public class GeneralRespnseFilter<TCollection>
    {
        public BaseFilter? Filter { get; set; }
        public TCollection? Collection { get; set; }
    }
}
