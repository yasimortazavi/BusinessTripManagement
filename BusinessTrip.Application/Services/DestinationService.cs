using BusinessTrip.Application.Interfaces.Repositories;
using BusinessTrip.Application.Interfaces.Services;
using BusinessTrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Application.Services
{
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;

        public DestinationService(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public Task<List<Destination>> GetAllAsync()
        {
          return  _destinationRepository.GetAllAsync();
        }
        public Task<Destination?> GetByIdAsync(int id)
        { 
            return _destinationRepository.GetByIdAsync(id);
        
        }
    }
}
