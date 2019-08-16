using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Generator;
using FiscalCodeLib.Models;
using FiscalCodeLib.Validator;
using Xunit;

namespace DataAccessTests
{
    public class ForeignCountriesTest
    {
        [Fact]
        public void FactoryTest()
        {
            var eu = ModelFactory.GetByName(typeof(Continent), "Europa") as Continent;
            Assert.Equal("Europa", eu.Name);
        }

        [Fact]
        public void PersonalInfoModelTest()
        {
            var person = new PersonalInfo("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "Andorra");
            Assert.Equal("Z101", person.PlaceOfBirth.Code);
        }

        [Fact]
        public void PlaceNameCaseTest()
        {
            var person = new PersonalInfo("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "BRONTE");
            Assert.Equal("B202", person.PlaceOfBirth.Code);
        }

        [Fact]
        public void ReadTest()
        {
            var countries = new List<ForeignCountry>();
            using (var dap = new SqliteDataAccessProvider())
            {
                countries = dap.ForeignCountries.ToList();
            }


            Assert.True(countries.Count > 0);
        }

        [Fact]
        public void GenerationTest()
        {
            var person = new PersonalInfo("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "BRONTE");
            FiscalCodeGenerator gen = new FiscalCodeGenerator(person);
            Assert.True(gen.FiscalCodes.Count == 8);
        }

        [Fact]
        public void LocalizationTest()
        {
            FiscalCode fc = new FiscalCode("DMCNRL90E03B202A");
            var person = new PersonalInfo("Andrea Luciano", "Damico", Gender.Male, new DateTime(1990, 5, 3),
                "BRONTE");
            FiscalCodeValidator validator = new FiscalCodeValidator(fc.ToString(), person, new CultureInfo("it-IT"));
            Assert.True(validator.ValidationResults.Count == 8);
        }
    }
}