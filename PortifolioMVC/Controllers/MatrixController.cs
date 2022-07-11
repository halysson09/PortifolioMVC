using Microsoft.AspNetCore.Mvc;
using PortifolioMVC.Models;
using System.Diagnostics;

namespace PortifolioMVC.Controllers
{
    public class MatrixController : Controller
    {
        private readonly ILogger<MatrixController> _logger;

        public MatrixController(ILogger<MatrixController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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