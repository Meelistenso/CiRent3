using CiRent.BL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CiRent.WebUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Category (int id)
        {
            return View();
        }
        public async Task<ActionResult> Item(int id)
        {
            DataHandler res = new DataHandler();
            var result = await res.BindProduct(id);
            return View(result);
        }
    }
}