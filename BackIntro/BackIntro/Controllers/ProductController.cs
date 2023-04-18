using Microsoft.AspNetCore.Mvc;

namespace BackIntro.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult Detail(int id)
        {
           

            return Content(id.ToString());
        }
        public ViewResult Index()
        {
            return View();

        }
       
       
        
    }
}
