using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using User_Save_Project.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace User_Save_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;
        public HomeController(DataContext _context)
        {
            context = _context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {


            return View();
        }
        [HttpGet]
        public IActionResult AddRequest()
        {


            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            

            context.Requests.Add(model);
            context.SaveChanges();


            return View("ThankYou", model);
        }
    }
}

