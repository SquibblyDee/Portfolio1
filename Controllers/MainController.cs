using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers     //be sure to use your own project's namespace!
{
    public class MainController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            ViewBag.Example = "What's in the bag?";
            return View();
        }

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/projects")]     //associated route string (exclude the leading /)
        public IActionResult Projects()
        {
            return View();
        }

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/contact")]     //associated route string (exclude the leading /)
        public IActionResult Contact()
        {
            return View();
        }

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/razor")]     //associated route string (exclude the leading /)
        public IActionResult Razor()
        {
            return View();
        }
    }
}