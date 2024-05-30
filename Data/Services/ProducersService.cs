using eTickets.Data.Repositories;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProducersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            return await _unitOfWork.ProducersRepository.GetAllAsync();
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            return await _unitOfWork.ProducersRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Producer producer)
        {
            await _unitOfWork.ProducersRepository.AddAsync(producer);
            await _unitOfWork.Commit();
        }

        public async Task UpdateAsync(int id, Producer producer)
        {
            await _unitOfWork.ProducersRepository.UpdateAsync(id, producer);
            await _unitOfWork.Commit();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.ProducersRepository.DeleteAsync(id);
            await _unitOfWork.Commit();
        }
    }
}
