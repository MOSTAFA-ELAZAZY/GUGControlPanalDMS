using Business.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.System.Countries
{
    public class CountryViewModel : BaseClassViewModel
    {
        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }

        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

    }
}
