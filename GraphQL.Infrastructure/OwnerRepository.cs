using GraphQL.Application.Interfaces;
using GraphQL.Domain.Entities;
 

namespace GraphQL.Infrastructure
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Owner> GetAll() => _context.Owners.ToList();

        public Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));
    } 
}
