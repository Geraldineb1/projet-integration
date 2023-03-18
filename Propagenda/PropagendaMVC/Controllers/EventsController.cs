using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;

namespace PropagendaMVC.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;
        public EventsController(IEventService eventService)
        {
            this._eventService = eventService;
        }

        // GET: EventController
        public async Task<ActionResult> Index()
        {
            var model = await _eventService.GetEvents();
            return View(model);
        }

        // GET: EventController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _eventService.GetEventDetails(id);
            return View(model);
        }

        // GET: EventController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: EventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateEventVM Event)
        {
            try
            {
                var response = await _eventService.CreateEvent(Event);
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

            return View(Event);
        }

        // GET: EventController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _eventService.GetEventDetails(id);
            return View(model);
        }

        // POST: EventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, EventVM serviceType)
        {
            try
            {
                var response = await _eventService.UpdateEvent(id, serviceType);
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

            return View(serviceType);
        }



        // POST: EventController/Delete/5
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _eventService.DeleteEvent(id);
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

            return BadRequest();
        }*/
    }
}
