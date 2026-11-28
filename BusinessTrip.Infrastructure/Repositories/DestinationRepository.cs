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

        public async Task<Destination?> GetByIdAsync(int id)
        {
            return await _context.Destinations
      .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Destination>> GetActiveAsync()
        {

            return await _context.Destinations.Where(e => e.IsActive )
                .OrderByDescending(e => e.Name)
                .ToListAsync();

        }
    }
}
