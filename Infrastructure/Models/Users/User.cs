using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Users
{
    public class User:BaseClass
    {
        [Required]  
        [StringLength(50)]
        public string NameAr { get; set; }


        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }


        [Required]
        [StringLength(50)]
        public string Password { get; set; }


       
    }
}
