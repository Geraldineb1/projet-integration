using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;

namespace PropagendaMVC.Controllers
{
    public class ServiceTypesController : Controller
    {
         
        private readonly IServiceTypeService _serviceTypeService;
        public ServiceTypesController(IServiceTypeService serviceTypeService)
        {
            this._serviceTypeService = serviceTypeService;
        }

        // GET: ServiceTypeController
        public async Task<ActionResult> Index()
        {
            var model = await _serviceTypeService.GetServiceTypes();
            return View(model);
        }

        // GET: ServiceTypeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _serviceTypeService.GetServiceTypeDetails(id);
            return View(model);
        }

        // GET: ServiceTypeController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ServiceTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateServiceTypeVM serviceType)
        {
            try
            {
                var response = await _serviceTypeService.CreateServiceType(serviceType);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
            }

            return View(serviceType);
        }

        // GET: ServiceTypeController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _serviceTypeService.GetServiceTypeDetails(id);
            return View(model);
        }

        // POST: ServiceTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ServiceTypeVM serviceType)
        {
            try
            {
                var response = await _serviceTypeService.UpdateServiceType(id, serviceType);
                if(response.Success)
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

        

        // POST: ServiceTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _serviceTypeService.DeleteServiceType(id);
                if(response.Success)
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
