using eTickets.Data.Repositories;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CinemasService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            return await _unitOfWork.CinemasRepository.GetAllAsync();
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            return await _unitOfWork.CinemasRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Cinema cinema)
        {
            await _unitOfWork.CinemasRepository.AddAsync(cinema);
            await _unitOfWork.Commit();
        }

        public async Task UpdateAsync(int id, Cinema cinema)
        {
            await _unitOfWork.CinemasRepository.UpdateAsync(id, cinema);
            await _unitOfWork.Commit();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.CinemasRepository.DeleteAsync(id);
            await _unitOfWork.Commit();
        }
    }
}
