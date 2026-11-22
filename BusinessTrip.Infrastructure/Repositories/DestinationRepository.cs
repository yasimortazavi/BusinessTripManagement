using BusinessTrip.Application.Interfaces.Repositories;
using BusinessTrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Infrastructure.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        public Task<List<Destination>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
