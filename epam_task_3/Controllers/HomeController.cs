using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsoleApp.Entity;

namespace epam_task_3.Controllers
{
    public class HomeController : Controller
    {
        private BookContext _context = new BookContext();
        
        [HttpGet]
        public ActionResult Index(int id)
        {   
            var _b = _context.Books.FirstOrDefault(x => x.Id == id);
            ViewBag.DataBooks = _b;
            var _g = _context.Ganres.FirstOrDefault(x => x.GanreId == id);
            ViewBag.DataGanres = _g;

                id++;
                ViewBag.DataIdNext = id;

            if (id > _context.Books.Count()) 
            {
                ViewBag.DataIdNext = 1;
            }
            
            return View();
        }
        
       
    }
}