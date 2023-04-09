using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;

namespace PropagendaMVC.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServicesController(IServiceService serviceService)
        {
            this._serviceService = serviceService;
        }

        // GET: ServiceController
        public async Task<ActionResult> Index()
        {
            var model = await _serviceService.GetServices();
            return View(model);
        }

        public async Task<ActionResult> ServicesToApprove()
        {
            var model = await _serviceService.GetServicesToApprove();
            return View(model);
        }

        // GET: ServiceController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _serviceService.GetServiceDetails(id);
            return View(model);
        }

        // GET: ServiceController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateServiceVM service)
        {
            try
            {
                var response = await _serviceService.CreateService(service);
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

            return View(service);
        }

        // GET: ServiceController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _serviceService.GetServiceDetails(id);
            return View(model);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ServiceVM service)
        {
            try
            {
                var response = await _serviceService.UpdateService(id, service);
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

            return View(service);
        }



        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _serviceService.DeleteService(id);
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

        // GET: ServicesController/Edit-approval/5
        public async Task<ActionResult> EditApproval(int id)
        {
            var model = await _serviceService.GetServiceDetails(id);
            ServiceToApproveVM serviceVM = new ServiceToApproveVM();
            serviceVM.Name = model.Name;
            serviceVM.IsApproved = model.IsApproved;

            return View(serviceVM);
        }

        // POST: ServicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditApproval(int id, ServiceToApproveVM service)
        {
            try
            {

                var response = await _serviceService.UpdateApproval(id, service);
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
            return View(service);
        }
    }
}
