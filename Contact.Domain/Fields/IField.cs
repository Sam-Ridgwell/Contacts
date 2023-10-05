using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Core;

namespace Contact.Domain.Fields
{
    public interface IField<T>
    {
        public Result<(bool, List<ValidationResult>)> Validate();

        public T Value { get; set; }

    }
}
