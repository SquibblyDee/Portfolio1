using Microsoft.AspNetCore.Mvc;
    namespace Portfolio1.Controllers     //be sure to use your own project's namespace!
    {
        public class MainController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public string Index()
            {
                return "This is my Index!";
            }

            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("/projects")]     //associated route string (exclude the leading /)
            public string Projects()
            {
                return "These are my projects";
            }

            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("/contact")]     //associated route string (exclude the leading /)
            public string Contact()
            {
                return "This is my Contact info!";
            }
        }
    }