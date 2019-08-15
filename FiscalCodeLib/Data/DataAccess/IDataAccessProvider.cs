using System.Collections.Generic;
using System.Threading.Tasks;
using FiscalCodeLib.Models;

namespace FiscalCodeLib.Data.DataAccess
{
    public interface IDataAccessProvider
    {
        Task<ItalianMunicipality> GetMunicipalityByNameAsync(string name);
        Task<List<ItalianMunicipality>> GetAllMunicipalitiesAsListAsync();
        Task<List<ForeignCountry>> GetAllForeignCountriesAsListAsync();
        ForeignCountry GetForeignCountryByNameAsync(string name);
        ItalianMunicipality GetMunicipalityByName(string name);
        List<ItalianMunicipality> GetAllMunicipalitiesAsList();
        ForeignCountry GetForeignCountryByName(string name);
        List<ForeignCountry> GetAllForeignCountriesAsList();
        List<Province> GetProvincesInRegion(string regionName);
        List<Region> GetAllRegionsAsList();

        List<ItalianMunicipality> GetMunicipalitiesInProvince(string provinceName);
        //TODO Add async versions
    }
}