using System;
using Xunit;
using FiscalCodeLib;
using FiscalCodeLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessTests
{
    public class ForeignCountriesTest
    {
        [Fact]
        public void ReadTest()
        {
            DataAccessProvider dap = new DataAccessProvider();
            List<ForeignCountryModel> countries = new List<ForeignCountryModel>();
            countries = dap.ForeignCountries.ToList();
            Assert.True(countries.Count > 0);
        }
    }
}