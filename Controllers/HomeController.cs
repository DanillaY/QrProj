using copyqr.Models;
using copyqr.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using copyqr.Models.Entities;

namespace copyqr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QrCodesContext _context;

        public HomeController(ILogger<HomeController> logger, QrCodesContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           return View(_context.QrInfos.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}