using BusinessTrip.Domain.Entities;


namespace BusinessTrip.Application.Interfaces.Repositories
{
    public interface IDestinationRepository
    {
        Task<List<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(int id);
        Task<List<Destination>> GetActiveAsync();
    }
}
