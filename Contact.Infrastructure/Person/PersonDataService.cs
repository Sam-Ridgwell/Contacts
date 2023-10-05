using Contact.Application.InfrastructureRepository.DataObjects;
using Contact.Application.InfrastructureRepository.Interfaces;
using Contacts.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Infrastructure.Person
{
    public class PersonDataService : IPersonDataService
    {
        public IPersonDto GetPersonById(int id)
        {
            return new PersonDto("John Smith");
        }

        public Result<bool> AddPerson(PersonDto person)
        {
            return new Result<bool>(true);
        }
    }
}
