using eTickets.Data.Repositories;
using eTickets.Data.ViewModels;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MoviesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PagedResult<Movie>> List(int page, int pageSize)
        {
            return await _unitOfWork.MoviesRepository.List(page, pageSize);
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _unitOfWork.MoviesRepository.GetByIdAsync(id);
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            return await _unitOfWork.MoviesRepository.GetNewMovieDropdownsValues();
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            await _unitOfWork.BeginTransaction();
            try
            {
                await _unitOfWork.MoviesRepository.AddNewMovieAsync(data);
                await _unitOfWork.Commit();
            }
            catch
            {
                await _unitOfWork.Rollback();
                throw;
            }
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            await _unitOfWork.BeginTransaction();
            try
            {
                await _unitOfWork.MoviesRepository.UpdateMovieAsync(data);
                await _unitOfWork.Commit();
            }
            catch
            {
                await _unitOfWork.Rollback();
                throw;
            }
        }

        public async Task<IEnumerable<Movie>> GetMoviesWithActorsAsync()
        {
            return await _unitOfWork.MoviesRepository.GetMoviesWithActorsAsync();
        }
    }
}
