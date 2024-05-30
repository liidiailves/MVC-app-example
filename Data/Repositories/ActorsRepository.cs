using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Repositories
{
    public class ActorsRepository : EntityBaseRepository<Actor>, IActorsRepository
    {
        public ActorsRepository(eTicketsContext context) : base(context)
        {
        }
    }
}