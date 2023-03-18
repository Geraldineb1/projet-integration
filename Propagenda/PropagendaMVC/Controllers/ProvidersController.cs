using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PropagendaMVC.Controllers
{
    public class ProvidersController : Controller
    {
        private readonly IProviderService _serviceProvider;
        public ProvidersController(IProviderService providerService)
        {
            this._serviceProvider = providerService;
        }
        // GET: ProvidersController
        public async Task<ActionResult> Index()
        {
            var model = await _serviceProvider.GetProviders();
            return View(model);
        }

        // GET: ProvidersController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _serviceProvider.GetProviderDetails(id);
            return View(model);
        }

        // GET: ProvidersController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ProvidersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateProviderVM provider)
        {
            try
            {
                provider.ApplicationUserId = ""; 
                var response = await _serviceProvider.CreateProvider(provider);
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
            

            return View(provider);
        }


        // GET: ProvidersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _serviceProvider.GetProviderDetails(id);
            UpdateProviderVM providerVM = new UpdateProviderVM();
            providerVM.Name = model.Name;
            providerVM.Bio = model.Bio;
            providerVM.Link = model.Link;
            providerVM.IsActive = model.IsActive;
            
            return View(providerVM);
        }

        // POST: ProvidersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, UpdateProviderVM provider)
        {
            try
            {
                
                var response = await _serviceProvider.UpdateProvider(id, provider);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }

                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(provider);
        }

        /*// GET: ProvidersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProvidersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/


    }
}
