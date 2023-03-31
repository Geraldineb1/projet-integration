using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;

namespace PropagendaMVC.Controllers
{
    public class TicketReservationsController : Controller
    {
        private readonly ITicketReservationService _ticketReservationService;
        public TicketReservationsController(ITicketReservationService ticketReservationService)
        {
            this._ticketReservationService = ticketReservationService;
        }

        // GET: TicketReservationController
        public async Task<ActionResult> Index()
        {
            var model = await _ticketReservationService.GetTicketReservations();
            return View(model);
        }

        // GET: TicketReservationController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _ticketReservationService.GetTicketReservationDetails(id);
            return View(model);
        }

        // GET: TicketReservationController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: TicketReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateTicketReservationVM ticketReservation)
        {
            try
            {
                var response = await _ticketReservationService.CreateTicketReservation(ticketReservation);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(ticketReservation);
        }

    }
}
