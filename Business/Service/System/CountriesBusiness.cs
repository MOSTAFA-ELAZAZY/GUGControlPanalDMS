using AutoMapper;
using AutoMapper.QueryableExtensions;
using Business.Enums;
using Business.ViewModels.General;
using Business.ViewModels.System.Countries;
using Infrastructure.Models.System;
using Infrastructure.Repositories.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.System
{
    public interface ICountriesBusiness 
    {
        Task<CountryViewModel> GetCountryAsync(int id);
        Task Update(CountryViewModel countryViewModel);
        Task<GeneralRespnseFilter<List<CountriesListViewModel>>> GetAll(BaseFilter filter);
        Task<IList<GenericDropDown>> GetDropDown(int lang);
    }
    public class CountriesBusiness: ICountriesBusiness
    {
        private readonly ICountriesRepository countriesRepository;
        private readonly IMapper mapper;
        public CountriesBusiness(ICountriesRepository countriesRepository, IMapper mapper)
        {
            this.countriesRepository = countriesRepository;
            this.mapper = mapper;
        }
       
        #region Get
        public async Task<IList<GenericDropDown>> GetDropDown(int lang)
        {
            var entities = (await countriesRepository.GetAllAsync()).Where(c => !c.IsDeleted);
            var model = entities.Select(c => new GenericDropDown() { ID = c.Id, Name = ((int)LanguageEnum.Arabic)==lang? c.NameAr:c.NameEn });
            return model.ToList();
        }

        public async Task<GeneralRespnseFilter<List<CountriesListViewModel>>> GetAll(BaseFilter filter)
        {
            var entities = (await countriesRepository.GetAllAsync()).Where(c => !c.IsDeleted);
            if (filter != null)
            {
                entities = entities.Skip(filter.PageIndex * filter.PageSize).Take(filter.PageSize);
               
            }
            else
            {
                filter = new BaseFilter();
            }
            filter.TotalCount = entities.Count();
            var result = new GeneralRespnseFilter<List<CountriesListViewModel>>()
            {
                Filter = filter,
                Collection = entities.Select(c=>new CountriesListViewModel()
                        {Id=c.Id,Name= filter.Lang==(int)LanguageEnum.Arabic?c.NameAr:c.NameEn }).ToList()
            };

            return result;
        }

        public async Task<CountryViewModel> GetCountryAsync(int id)
        {
            var entity = (await countriesRepository.GetAllAsync()).Where(c => c.Id == id).Select(c => c).FirstOrDefault();

            return mapper.Map<CountryViewModel>(entity);
        }

        #endregion

        #region delete
        public async Task Delete(int id)
        {
            var entity = (await countriesRepository.GetAllAsync()).Where(c => c.Id == id).Select(c => c).FirstOrDefault();
            if (entity != null)
            {
                await countriesRepository.Delete(entity);
                await countriesRepository.Commit();
            }
        }
        #endregion

        #region update
        public async Task Update(CountryViewModel countryViewModel)
        {

            var entity = mapper.Map<Country>(countryViewModel);
            await countriesRepository.Update(entity);
            await countriesRepository.Commit();
        }
        #endregion



    }
}
