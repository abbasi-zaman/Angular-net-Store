using Microsoft.AspNetCore.Mvc;
using Web.Common;

namespace Web.Controllers
{
    public class ProductController : BaseApiController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
