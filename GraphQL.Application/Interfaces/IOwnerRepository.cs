using GraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Application.Interfaces
{
    
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(Guid id);
    }
}
