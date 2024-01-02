using AutoMapper;
using Business.ViewModels.System.Countries;
using Infrastructure.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class SystemMapper : Profile
    {
        public SystemMapper() 
        {
            CreateMap<Country, CountryViewModel>().ReverseMap();

        }
    }
}
