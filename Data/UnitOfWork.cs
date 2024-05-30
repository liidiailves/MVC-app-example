using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using eTickets.Data.Repositories;

namespace eTickets.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly eTicketsContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(eTicketsContext context)
        {
            _context = context;
        }

        private IActorsRepository _actorsRepository;
        private ICinemasRepository _cinemasRepository;
        private IProducersRepository _producersRepository;
        private IMoviesRepository _moviesRepository;

        public IActorsRepository ActorsRepository => _actorsRepository ??= new ActorsRepository(_context);
        public ICinemasRepository CinemasRepository => _cinemasRepository ??= new CinemasRepository(_context);
        public IProducersRepository ProducersRepository => _producersRepository ??= new ProducersRepository(_context);
        public IMoviesRepository MoviesRepository => _moviesRepository ??= new MoviesRepository(_context);

        public async Task BeginTransaction()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();
        }

        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
