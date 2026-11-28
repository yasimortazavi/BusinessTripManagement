using BusinessTrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Application.Interfaces.Services
{
    public interface IDestinationService
    {
        Task<List<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(int id);
        Task<List<Destination>> GetActiveAsync();
    } 


}
