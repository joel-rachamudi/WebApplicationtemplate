using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationtemplate.Models;
using Newtonsoft.Json;



namespace WebApplicationtemplate.Controllers
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
        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Products()
           
        {
            string filePath = "C:\\databeat_JOEL\\THE_GOOD_GUY project\\learn\\intern-task2\\WebApplicationtemplate\\jsontext.txt";

            List<Product> myDeserializedClass = JsonConvert.DeserializeObject<List<Product>>(filePath);
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
    }
}