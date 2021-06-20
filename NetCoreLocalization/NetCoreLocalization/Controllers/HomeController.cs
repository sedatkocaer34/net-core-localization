using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using NetCoreLocalization.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLocalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        private readonly IStringLocalizer<SharedResources> _localizerModel;

        public HomeController(ILogger<HomeController> logger , IStringLocalizer<HomeController> localizer, IStringLocalizer<SharedResources> localizerModel)
        {
            _logger = logger;
            _localizer = localizer;
            _localizerModel = localizerModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = _localizer.GetString("Message");
            return View();
        }

        [HttpPost]
        public IActionResult Kaydet(ContactFormViewModel viewModel)
        {
            
            return View("Contact", viewModel);

        }

        public IActionResult Privacy()
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
