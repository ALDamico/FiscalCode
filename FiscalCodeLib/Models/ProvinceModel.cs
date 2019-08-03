using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class ProvinceModel : IFiscalCodeModel
    {
        public ProvinceModel(string name, string abbreviation, string alternativeName, int regionId)
        {
            Name = name;
            Abbreviation = abbreviation;
            RegionId = regionId;
            AlternativeName = alternativeName;
            using (var dap = new DataAccessProvider())
            {
                Region = dap.Regions.FirstOrDefault(r => r.Id == regionId);
            }
        }

        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Id { get; set; }

        [NotMapped] public RegionModel Region { get; }

        public int RegionId { get; set; }
        public string AlternativeName { get; set; }
    }
}