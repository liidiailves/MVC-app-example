using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Repositories
{
    public interface IMoviesRepository : IEntityBaseRepository<Movie>
    {
        Task<PagedResult<Movie>> List(int page, int pageSize);
        new Task<Movie> GetByIdAsync(int id);  // Lisa new märksõna
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task<IEnumerable<Movie>> GetMoviesWithActorsAsync();
    }
}
