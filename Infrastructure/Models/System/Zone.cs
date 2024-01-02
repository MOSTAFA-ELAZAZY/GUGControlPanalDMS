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
    public class Zone: BaseClass
    {
        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }


        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

        public int CityID { get; set; }
        [ForeignKey(nameof(CityID))]
        public City City { get; set; }
    }
}
