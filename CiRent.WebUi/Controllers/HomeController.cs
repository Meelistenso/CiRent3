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
        public async Task<ActionResult> Index()
        {
            DataHandler scope = new DataHandler();
            var res = await scope.BindMainCategories();
            return View(res);
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
        //public async Task<ActionResult> Category(int id)
        //{
        //    DataHandler res = new DataHandler();
        //    var result= await res.BindProducts(id);
        //    return View(result);
        //}
        public async Task<ActionResult> Category(int id,int? page,string sorted)
        {
            DataHandler res = new DataHandler();
            List<ProductsModel> result;
            
            if (page!=null) {
                 result = await res.BindProducts(id,(int)page,sorted);
            }
            else if(sorted!=null) {
                result = await res.BindProducts(id,sorted);
            }
            else
            {
               result = await res.BindProducts(id);
            }
            
            return View("Category",result);
        }
        public async Task<ActionResult> Item(int id)
        {
            DataHandler res = new DataHandler();
            var result = await res.BindProduct(id);
            return View(result);

        }
        public async Task<ActionResult> Search(string text)
        {
            DataHandler res = new DataHandler();
            var result = await res.BindProducts(text);
            return View(result);
        }
    }
}