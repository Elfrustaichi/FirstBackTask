using Microsoft.AspNetCore.Mvc;

namespace BackIntro.Controllers
{
    public class HomeController : Controller
    {
      public ViewResult Index()
        {
            ViewResult result = View();
            result.ViewName = "Index";
            return result;

        }
        public ViewResult About()
        {
            ViewResult result = View();
            result.ViewName = "About";
            return result;

        }

        public ViewResult Contact()
        {
            ViewResult result = View();
            result.ViewName = "Contact";
            return result;

        }



    }
}
