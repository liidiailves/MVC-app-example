using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Repositories
{
    public class CinemasRepository : EntityBaseRepository<Cinema>, ICinemasRepository
    {
        public CinemasRepository(eTicketsContext context) : base(context)
        {
        }
    }
}
