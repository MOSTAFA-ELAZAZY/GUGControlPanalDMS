using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.System
{
    public class Country : BaseClass
    {
        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }


        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }
    }
}
