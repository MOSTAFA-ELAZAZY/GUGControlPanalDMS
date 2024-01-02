using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.System
{
    
    public class Trip: BaseClass
    {
        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }


        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
