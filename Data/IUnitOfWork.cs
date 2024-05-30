using eTickets.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IActorsRepository ActorsRepository { get; }
        ICinemasRepository CinemasRepository { get; }
        IProducersRepository ProducersRepository { get; }
        IMoviesRepository MoviesRepository { get; }
        Task BeginTransaction();
        Task Commit();
        Task Rollback();
    }
}