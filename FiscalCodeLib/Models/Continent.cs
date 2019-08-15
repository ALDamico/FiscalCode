using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class Continent : IFiscalCodeModel
    {
        public Continent(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}