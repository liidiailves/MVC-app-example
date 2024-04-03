using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface IMoviesService : IEntityBaseRepository<Movie>
	{
        Task<PagedResult<Movie>> List(int page, int pageSize);
        Task<Movie> GetMovieByIdAsync(int id);
		Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
		Task AddNewMovieAsync(NewMovieVM data);
		Task UpdateMovieAsync(NewMovieVM data);
	}
}
