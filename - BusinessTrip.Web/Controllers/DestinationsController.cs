using BusinessTrip.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTrip.Web.Controllers
{
    public class DestinationsController : Controller
    {

        private readonly IDestinationService _destinationService;

        public DestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        // GET: DestinationsController
        public async Task<ActionResult> Index()
        {
             var model = await  _destinationService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        { 
            var destination = await _destinationService.GetByIdAsync(id);
            if (destination == null)
            {
                return NotFound();
            }

            return View(destination);

        }
        public async Task<IActionResult> Active()
        {
            var activeDestinations = await _destinationService.GetActiveAsync();
            if (activeDestinations == null)
            {
                return NotFound();
            }

            return View(activeDestinations);
        
        }
    }
}
