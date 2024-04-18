using GraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Application.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccountsPerOwner(Guid ownerId);
        Task<ILookup<Guid, Account>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds);
    } 
}
