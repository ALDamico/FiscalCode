using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class Region : IFiscalCodeModel
    {
        public string Name { get; private set; }
        public string AlternativeName { get; private set; }
        public int Id { get; private set; }
    }
}