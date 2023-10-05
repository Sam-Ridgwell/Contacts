using Contact.Application.ApiRepository.Interfaces;
using Contacts.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Application.Services.Interfaces
{
    public interface IPersonService
    {
        public Result<IPersonApo> GetPersonById(int id);

        public Result<bool> AddPerson(IPersonApo person);
    }
}
