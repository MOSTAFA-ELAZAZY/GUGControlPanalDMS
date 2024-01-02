using Infrastructure.Context;
using Infrastructure.Models.System;
using Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.System
{
    public interface ICountriesRepository:IBaseRepository<Country>
    {

    }

    public class CountriesRepository : BaseRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(GUGContext GUGContext) : base(GUGContext) { }
    }
}
