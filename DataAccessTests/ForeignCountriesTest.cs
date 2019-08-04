using System;
using System.Collections.Generic;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Models;
using Xunit;

namespace DataAccessTests
{
    public class ForeignCountriesTest
    {
        [Fact]
        public void FactoryTest()
        {
            var eu = ModelFactory.GetByName(typeof(ContinentModel), "Europa") as ContinentModel;
            Assert.Equal("Europa", eu.Name);
        }

        [Fact]
        public void PersonalInfoModelTest()
        {
            var person = new PersonalInfoModel("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "Andorra");
            Assert.Equal("Z101", person.PlaceOfBirth.Code);
        }

        [Fact]
        public void PlaceNameCaseTest()
        {
            var person = new PersonalInfoModel("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "BRONTE");
            Assert.Equal("B202", person.PlaceOfBirth.Code);
        }

        [Fact]
        public void ReadTest()
        {
            var countries = new List<ForeignCountryModel>();
            using (var dap = new DataAccessProvider())
            {
                countries = dap.ForeignCountries.ToList();
            }


            Assert.True(countries.Count > 0);
        }

        [Fact]
        public void SurnameTripletTest()
        {
            var person = new PersonalInfoModel("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "BRONTE");
            var fc = new FiscalCodeModel(person);
            Assert.Equal("DMC", fc.SurnameTriplet);
        }
    }
}