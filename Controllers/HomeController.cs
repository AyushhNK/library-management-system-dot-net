using Microsoft.AspNetCore.Mvc;

namespace library_management_system_dot_net.Controllers
{
    public class HomeController : Controller
    {
    	private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
