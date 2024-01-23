using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class APIController : Controller
    {
        private readonly MyDBContext _dbContext;

        public APIController(MyDBContext context)

        {

            _dbContext = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var cities = _dbContext.Addresses.Select(a=>a.City).Distinct();
            return Json(cities);
        }
    }
}
