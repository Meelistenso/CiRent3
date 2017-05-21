using CiRent.BL.Concrete;
using CiRent.BL.Entities;
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
        
        public async Task<ActionResult> Category(int id,string page,string sorted)
        {
            DataHandler res = new DataHandler();
            List<ProductsModel> result;
            if (page!="") {
                 result = await res.BindProducts(id, int.Parse(page),sorted);
            }
            else
            {
                 result = await res.BindProducts(id,sorted);
            }
            
            return View("Category",result);
        }
    }
}