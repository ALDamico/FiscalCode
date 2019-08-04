using System;
using System.Collections.Generic;
using FiscalCodeLib.Models;

namespace FiscalCodeLib.Generator
{
    public class FiscalCodeGenerator
    {
        private readonly Queue<PersonalInfoModel> _personsToProcess;

        public FiscalCodeGenerator(PersonalInfoModel person) : this()
        {
            _personsToProcess.Enqueue(person);
        }

        public FiscalCodeGenerator(ICollection<PersonalInfoModel> persons) : this()
        {
            foreach (var person in persons) _personsToProcess.Enqueue(person);
        }

        public FiscalCodeGenerator()
        {
            _personsToProcess = new Queue<PersonalInfoModel>();
        }

        public void AddPerson(PersonalInfoModel person)
        {
            _personsToProcess.Enqueue(person);
        }

        public void RemovePerson(PersonalInfoModel person)
        {
            throw new NotImplementedException();
        }
    }
}