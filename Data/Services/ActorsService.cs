using eTickets.Data.Repositories;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            return await _unitOfWork.ActorsRepository.GetAllAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await _unitOfWork.ActorsRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Actor actor)
        {
            await _unitOfWork.ActorsRepository.AddAsync(actor);
            await _unitOfWork.Commit();
        }

        public async Task UpdateAsync(int id, Actor actor)
        {
            await _unitOfWork.ActorsRepository.UpdateAsync(id, actor);
            await _unitOfWork.Commit();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.ActorsRepository.DeleteAsync(id);
            await _unitOfWork.Commit();
        }
    }
}
