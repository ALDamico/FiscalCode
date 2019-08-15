using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class Region : IFiscalCodeModel
    {
        public Region(string name, string alternativeName)
        {
            Name = name;
            AlternativeName = alternativeName;
        }

        public string Name { get; private set; }
        public string AlternativeName { get; private set; }
        public int Id { get; set; }
    }
}