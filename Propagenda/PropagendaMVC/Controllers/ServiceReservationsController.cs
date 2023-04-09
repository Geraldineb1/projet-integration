using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;

namespace PropagendaMVC.Controllers
{
    public class ServiceReservationsController : Controller
    {
        private readonly IServiceReservationService _serviceReservationService;
        public ServiceReservationsController(IServiceReservationService serviceReservationService)
        {
            this._serviceReservationService = serviceReservationService;
        }

        // GET: ServiceReservationController
        public async Task<ActionResult> Index()
        {
            var model = await _serviceReservationService.GetServiceReservations();
            return View(model);
        }

        public async Task<ActionResult> ServiceReservationsToApprove()
        {
            var model = await _serviceServiceReservation.GetServiceReservationsToApprove();
            return View(model);
        }

        // GET: ServiceReservationController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _serviceReservationService.GetServiceReservationDetails(id);
            return View(model);
        }

        // GET: ServiceReservationController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ServiceReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateServiceReservationVM serviceReservation)
        {
            try
            {
                var response = await _serviceReservationService.CreateServiceReservation(serviceReservation);
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

            return View(serviceReservation);
        }

        // GET: ServiceReservationController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _serviceReservationService.GetServiceReservationDetails(id);
            return View(model);
        }

        // POST: ServiceReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ServiceReservationVM serviceReservation)
        {
            try
            {
                var response = await _serviceReservationService.UpdateServiceReservation(id, serviceReservation);
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

            return View(serviceReservation);
        }

        // GET: ServiceReservationsController/Edit-approval/5
        public async Task<ActionResult> EditApproval(int id)
        {
            var model = await _serviceServiceReservation.GetServiceReservationDetails(id);
            ServiceReservationToApproveVM serviceReservationVM = new ServiceReservationToApproveVM();
            serviceReservationVM.Name = model.Name;
            serviceReservationVM.IsApproved = model.IsApproved;

            return View(serviceReservationVM);
        }

        // POST: ServiceReservationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditApproval(int id, ServiceReservationToApproveVM serviceReservation)
        {
            try
            {

                var response = await _serviceServiceReservation.UpdateApproval(id, serviceReservation);
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
            return View(serviceReservation);
        }

        // POST: ServiceReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _serviceReservationService.DeleteServiceReservation(id);
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
        }
    }
}
