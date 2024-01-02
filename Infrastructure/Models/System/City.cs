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
    public class City: BaseClass
    {
        public City()
        {
            Zones=new HashSet<Zone>();
        }
        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }


        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

        [Required]
        public int CountryID { get; set; }

        [ForeignKey(nameof(CountryID))]
        public Country Country { get; set; }

        public ICollection<Zone> Zones { get; set; }
    }
}
