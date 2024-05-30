using eTickets.Data.ViewModels;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IMoviesService
    {
        Task<PagedResult<Movie>> List(int page, int pageSize);
        Task<Movie> GetByIdAsync(int id); 
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task<IEnumerable<Movie>> GetMoviesWithActorsAsync();
    }
}
