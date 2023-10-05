using Contact.Application.ApiRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Application.Services.Interfaces
{
    public interface IPersonService
    {
        public IPersonApo GetPersonById(int id);

        public bool AddPerson(IPersonApo person);
    }
}
