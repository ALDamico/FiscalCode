namespace FiscalCodeLib.Models
{
    public class ContinentModel
    {
        public ContinentModel(int id, string name)
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