using Microsoft.AspNetCore.Mvc;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using System.Diagnostics;

namespace PropagendaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEventService _eventService;
        private readonly IProviderService _providerService;
        private readonly IServiceService _serviceService;

        public HomeController(ILogger<HomeController> logger, IEventService eventService, IProviderService providerService, IServiceService serviceService)
        {
            _logger = logger;
            _eventService = eventService;
            _providerService = providerService;
            _serviceService = serviceService;
        }

        public async Task<ActionResult> Index()
        {
            HomeVM vm = new HomeVM();
            vm.Events = await _eventService.GetEvents();
            vm.Providers = await _providerService.GetProviders();
            vm.Services = await _serviceService.GetServices();
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}