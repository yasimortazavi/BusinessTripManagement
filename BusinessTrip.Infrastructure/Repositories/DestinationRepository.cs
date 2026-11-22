using BusinessTrip.Application.Interfaces.Repositories;
using BusinessTrip.Domain.Entities;
using BusinessTrip.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Infrastructure.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly BusinessTripDbContext _context;

        public DestinationRepository(BusinessTripDbContext businessTripDbContext)
        {
            _context = businessTripDbContext;
        }

        public async Task<List<Destination>> GetAllAsync()
        {
           return  await _context.Destinations.ToListAsync();
        }
    }
}
