using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Repositories
{
    public class ProducersRepository : EntityBaseRepository<Producer>, IProducersRepository
    {
        public ProducersRepository(eTicketsContext context) : base(context)
        {
        }
    }
}
