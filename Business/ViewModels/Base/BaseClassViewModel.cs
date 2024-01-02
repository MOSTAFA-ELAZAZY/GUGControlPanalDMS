using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.Base
{
    public class BaseClassViewModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }
        public bool IsDeleted { get; set; }

        public int? DeletedBy { get; set; }

    }
}
