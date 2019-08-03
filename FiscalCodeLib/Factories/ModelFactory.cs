using System;
using System.Collections.Generic;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Interfaces;
using FiscalCodeLib.Models;

namespace FiscalCodeLib.Factories
{
    public static class ModelFactory
    {
        private static readonly List<string> _typeList;

        static ModelFactory()
        {
            using (var db = new DataAccessProvider())
            {
                _typeList = new List<string>();
                var entityTypes = db.Model.GetEntityTypes().ToList();
                foreach (var entityType in entityTypes) _typeList.Add(entityType.ClrType.Name);
            }
        }

        public static IFiscalCodeModel GetByName(Type modelType, string name)
        {
            using (var db = new DataAccessProvider())
            {
                var targetType = _typeList.FirstOrDefault(t => t == modelType.Name);


                if (targetType == nameof(ContinentModel))
                    return db.Continents.FirstOrDefault(c => c.Name == name);
                if (targetType == nameof(ForeignCountryModel))
                    return db.ForeignCountries.FirstOrDefault(fc => fc.Name == name);
                if (targetType == nameof(ProvinceModel))
                    return db.Provinces.FirstOrDefault(p => p.Name == name);
                if (targetType == nameof(RegionModel))
                    return db.Regions.FirstOrDefault(r => r.Name == name);
                if (targetType == nameof(ItalianMunicipalityModel))
                    return db.ItalianMunicipalities.FirstOrDefault(m => m.Name == name);
                throw new NotSupportedException($"Can't determine an entity for type {targetType}");
            }
        }

        public static IFiscalCodeModel GetById(Type modelType, int id)
        {
            using (var db = new DataAccessProvider())
            {
                var targetType = _typeList.FirstOrDefault(t => t == modelType.Name);

                if (targetType == nameof(ContinentModel))
                {
                    var output = db.Continents.FirstOrDefault(c => c.Id == id);
                    return output;
                }

                if (targetType == nameof(ForeignCountryModel))
                    return db.ForeignCountries.FirstOrDefault(fc => fc.Id == id);
                if (targetType == nameof(ProvinceModel))
                    return db.Provinces.FirstOrDefault(p => p.Id == id);
                if (targetType == nameof(RegionModel))
                    return db.Regions.FirstOrDefault(r => r.Id == id);
                if (targetType == nameof(ItalianMunicipalityModel))
                    return db.ItalianMunicipalities.FirstOrDefault(m => m.Id == id);
                throw new NotSupportedException($"Can't determine an entity for type {targetType}");
            }
        }

        public static IPlace GetByPlaceName(string name)
        {
            using (var db = new DataAccessProvider())
            {
                IPlace place = db.ItalianMunicipalities.FirstOrDefault(p =>
                    string.Equals(p.Name, name, StringComparison.CurrentCultureIgnoreCase));
                if (place == null)
                    place = db.ForeignCountries.FirstOrDefault(p =>
                        string.Equals(p.Name, name, StringComparison.CurrentCultureIgnoreCase));

                if (place == null) throw new ArgumentNullException($"Can't find an entity whose name matches {name}");

                return place;
            }
        }
    }
}